using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath (this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        public static List<string> LoadFile (this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
        #region Conversion to models
        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);
            }

            return output;
        }

        public static List<PersonModel> ConvertToPersonModel(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];

                output.Add(p);
            }

            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
        {
            //id,team name, id's separated by pipe
            // 1, winners , 1|4|3
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');
                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }
            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines)
        {
            //id, tournament name, fee,(id|id|id - teams ids),(id|id|id - prize ids),(id^id^id|id^id^id - matchups/rounds ids)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels();
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();
            List<MatchupModel> matchups = GlobalConfig.MatchupsFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');
                foreach(string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                if (cols[4].Length > 0)
                {
                    string[] prizeIds = cols[4].Split('|');
                    foreach (string id in prizeIds)
                    {
                        tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    } 
                }

                //capture rounds information
                string[] rounds = cols[5].Split('|');
                
                foreach (string r in rounds)
                {
                    List<MatchupModel> round = new List<MatchupModel>();
                    string[] ms = r.Split('^');

                    foreach (string matchupModelTextId in ms)
                    {
                        round.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
                    }
                    tm.Rounds.Add(round);
                }
                output.Add(tm);
            }
            return output;
        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupEntryModel me = new MatchupEntryModel();
                me.Id = int.Parse(cols[0]);
                int teamId = 0;
                if(int.TryParse(cols[1], out teamId))
                {
                    me.TeamCompeting = LookupTeamById(teamId);
                }
                else
                {
                    me.TeamCompeting = null;
                }
               
                me.Score = double.Parse(cols[2]);

                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {
                    me.ParentMatchup = LookupMatchupById(parentId);
                }
                else
                {
                    me.ParentMatchup = null;
                }

                output.Add(me);
            }
            return output;
        }
        public static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<string> entries = GlobalConfig.MatchupEntriesFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();
            foreach (string id in ids)
            {
               foreach(string entry in entries)
                {
                    string[] cols = entry.Split(',');

                    if(cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }
            output = matchingEntries.ConvertToMatchupEntryModels();
            return output;
        }
        public static TeamModel LookupTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile();
            
            foreach (string team in teams)
            {
                string[] cols = team.Split(',');
                if(cols[0] == id.ToString())
                {
                    List<string> matchingTeams = new List<string>();
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertToTeamModels().First();
                }
            }
            return null;
        }
        public static MatchupModel LookupMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupsFile.FullFilePath().LoadFile();

            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);
                    return matchingMatchups.ConvertToMatchupModels().First();
                }
            }
            return null;
        }
        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupModel p = new MatchupModel();
                p.Id = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntryModels(cols[1]);
                int id = 0;
                if(int.TryParse(cols[2], out id))
                {
                    p.Winner = LookupTeamById(id);
                }
                else
                {
                    p.Winner = null;
                }
                
                p.MatchupRound = int.Parse(cols[3]);

                output.Add(p);
            }

            return output;
        }
        #endregion
        #region Saving to files
        public static void SaveToPrizesFile(this List<PrizeModel> models)
        {
            List<string> lines = new List<string>();
            foreach(PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in models)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.CellphoneNumber }");
            }

            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
        }

        public static void SaveToTeamsFile(this List<TeamModel> models)
        {
            List<string> lines = new List<string>();
            foreach (TeamModel t in models)
            {
                lines.Add($"{ t.Id },{ t.TeamName },{ ConvertPeopleListToString(t.TeamMembers) }");
            }

            File.WriteAllLines(GlobalConfig.TeamsFile.FullFilePath(), lines);

        }

        public static void SaveRoundToFile(this TournamentModel model)
        {
            //loop through each round
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    // load all of the matchups from file
                    //get the top id and add one
                    // store the id
                    // save the matchup record
                    matchup.SaveMatchupToFile();

                    
                }
            }
            //looptrhrough each matchup
            //get the id for the new matchup and save the record
            //loop thhrough each entry, get the id and save the entry

        }
        public static void SaveMatchupToFile(this MatchupModel model)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupsFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            int currentId = 0;
            if(matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            foreach (MatchupEntryModel entry in model.Entries)
            {
                entry.SaveEntryToFile();
            }
            matchups.Add(model);
            List<string> lines = new List<string>();
            foreach(MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{ m.Id },{ ConvertMatchupEntryListToString(m.Entries) },{ winner },{ m.MatchupRound }");
            }

            File.WriteAllLines(GlobalConfig.MatchupsFile.FullFilePath(), lines);
        }

        public static void SaveEntryToFile(this MatchupEntryModel model)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntriesFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int currentId = 0;
            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            entries.Add(model);
            List<string> lines = new List<string>();
            foreach (MatchupEntryModel entry in entries)
            {
                string parent = "";
                if (entry.ParentMatchup != null)
                {
                    parent = entry.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if(entry.TeamCompeting != null)
                {
                    teamCompeting = entry.TeamCompeting.Id.ToString();
                }
                lines.Add($"{ entry.Id },{ teamCompeting },{ entry.Score },{ parent }");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntriesFile.FullFilePath(), lines);
        }

        public static void SaveToTournamentsFile(this List<TournamentModel> models)
        {
            List<string> lines = new List<string>();
            foreach (TournamentModel tm in models)
            {
                lines.Add($"{ tm.Id },{ tm.TournamentName },{ tm.EntryFee },{ ConvertTeamsListToString(tm.EnteredTeams) },{ ConvertPrizesListToString(tm.Prizes) },{ ConvertRoundListToString(tm.Rounds) }");
            }

            File.WriteAllLines(GlobalConfig.TournamentsFile.FullFilePath(), lines);
        }


        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";
            if (people.Count == 0)
            {
                return "";
            }

            foreach (PersonModel p in people)
            {
                output += $"{ p.Id }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertTeamsListToString(List<TeamModel> teams)
        {
            string output = "";
            if (teams.Count == 0)
            {
                return "";
            }

            foreach (TeamModel t in teams)
            {
                output += $"{ t.Id }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertPrizesListToString(List<PrizeModel> prizes)
        {
            string output = "";
            if (prizes.Count == 0)
            {
                return "";
            }

            foreach (PrizeModel p in prizes)
            {
                output += $"{ p.Id }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";
            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ ConvertMatchupListToString(r) }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";
            if (matchups.Count == 0)
            {
                return "";
            }

            foreach (MatchupModel m in matchups)
            {
                output += $"{ m.Id }^";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertMatchupEntryListToString(List<MatchupEntryModel> entries)
        {
            string output = "";
            if (entries.Count == 0)
            {
                return "";
            }

            foreach (MatchupEntryModel e in entries)
            {
                output += $"{ e.Id }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }
        #endregion

        #region UPDATES
        public static void UpdateMatchupToFile(this MatchupModel model)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupsFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            MatchupModel oldMatchup = new MatchupModel();
            foreach (MatchupModel m in matchups)
            {
                if (m.Id == model.Id)
                {
                    oldMatchup = m;
                }
            }
            matchups.Remove(oldMatchup);
            foreach (MatchupEntryModel entry in model.Entries)
            {
                entry.UpdateEntryToFile();
            }
            matchups.Add(model);
            List<string> lines = new List<string>();
            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{ m.Id },{ ConvertMatchupEntryListToString(m.Entries) },{ winner },{ m.MatchupRound }");
            }

            File.WriteAllLines(GlobalConfig.MatchupsFile.FullFilePath(), lines);
        }

        public static void UpdateEntryToFile(this MatchupEntryModel model)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntriesFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            MatchupEntryModel oldEntry = new MatchupEntryModel();
            foreach (MatchupEntryModel e in entries)
            {
                if (e.Id == model.Id)
                {
                    oldEntry = e;
                }
            }
            entries.Remove(oldEntry);
            entries.Add(model);
            List<string> lines = new List<string>();
            foreach (MatchupEntryModel entry in entries)
            {
                string parent = "";
                if (entry.ParentMatchup != null)
                {
                    parent = entry.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (entry.TeamCompeting != null)
                {
                    teamCompeting = entry.TeamCompeting.Id.ToString();
                }
                lines.Add($"{ entry.Id },{ teamCompeting },{ entry.Score },{ parent }");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntriesFile.FullFilePath(), lines);
        }
        #endregion
    }
}
