using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);

            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));
            CreateOtherRounds(model, rounds);
           
        }
        public static void UpdateTournamentResults(TournamentModel model)
        {
            List<MatchupModel> toScore = new List<MatchupModel>();
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel rm in round)
                {
                    if (rm.Winner == null && (rm.Entries.Any(x => x.Score != 0) || rm.Entries.Count == 1))
                    {
                        toScore.Add(rm);
                    }
                }
            }
            MarkWinnersInMatchups(toScore);
            AdvanceWinners(toScore, model);

            toScore.ForEach(x => GlobalConfig.Connection.UpdateMatchup(x));
                //GlobalConfig.Connection.UpdateMatchup(m);
        }
        private static void AdvanceWinners(List<MatchupModel> models, TournamentModel tournament)
        {
            foreach (MatchupModel m in models)
            {
                foreach (List<MatchupModel> round in tournament.Rounds)
                {
                    foreach (MatchupModel rm in round)
                    {
                        foreach (MatchupEntryModel me in rm.Entries)
                        {
                            if (me.ParentMatchup != null)
                            {
                                if (me.ParentMatchup.Id == m.Id)
                                {
                                    me.TeamCompeting = m.Winner;
                                    GlobalConfig.Connection.UpdateMatchup(rm);
                                }
                            }
                        }
                    }
                } 
            }
        }
        private static void MarkWinnersInMatchups(List<MatchupModel> models)
        {
            string greaterWins = ConfigurationManager.AppSettings["greaterWins"];
           
            foreach (MatchupModel m in models)
            {
                //check for bye weeks
                if (m.Entries.Count == 1)
                {
                    m.Winner = m.Entries[0].TeamCompeting;
                    continue;
                }
                // low score wins
                if (greaterWins == "0")
                {
                    if (m.Entries[1] != null && m.Entries[1].Score == m.Entries[0].Score)
                    {
                        throw new Exception("We do not allow ties in this application");
                    }
                    m.Winner = m.Entries.OrderBy(x => x.Score).First().TeamCompeting;
                
                }
                else // highscore wins
                {
                    if (m.Entries[1] != null && m.Entries[1].Score == m.Entries[0].Score)
                    {
                        throw new Exception("We do not allow ties in this application");
                    }
                    m.Winner = m.Entries.OrderByDescending(x => x.Score).First().TeamCompeting;
                } 
            }
        }
        private static void CreateOtherRounds(TournamentModel model, int numberOfRounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currentRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();
            while(round <= numberOfRounds)
            {
                foreach(MatchupModel match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });
                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currentRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }
                model.Rounds.Add(currentRound);
                previousRound = currentRound;
                currentRound = new List<MatchupModel>();
                round++;
            }
        }
        private static List<MatchupModel> CreateFirstRound (int numberOfByes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();
            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                if (numberOfByes > 0 || curr.Entries.Count >1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();

                    if (numberOfByes > 0)
                    {
                        numberOfByes--;
                    }
                }
            }

            return output;
        }
        private static int NumberOfByes(int rounds, int teamCount)
        {
            return (int)(Math.Pow(2, rounds)) - teamCount;
        }

        private static int FindNumberOfRounds(int teamCount)
        {
            double log = Math.Log(teamCount, 2);
            return (int)Math.Ceiling(log);
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
           return teams.OrderBy(a => Guid.NewGuid()).ToList();
        }

    }
}
