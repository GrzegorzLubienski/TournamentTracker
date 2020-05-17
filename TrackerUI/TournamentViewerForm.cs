using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        List<string> rounds = new List<string>();
        List<MatchupModel> selectedMatchups = new List<MatchupModel>();
        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;
            LoadFormData();
            LoadRounds();
        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;

        }

        private void WireUpRoundLists()
        {
            ddRound.DataSource = null;
            ddRound.DataSource = rounds;
        }

        private void WireUpMatchupsLists()
        {
            lbMatchup.DataSource = null;
            lbMatchup.DataSource = selectedMatchups;
            lbMatchup.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds = new List<string>();
            foreach (List<MatchupModel> round in tournament.Rounds)
            {
                    rounds.Add($"Round {round.First().MatchupRound}");  
            }
            WireUpRoundLists();
        }

        private void LoadMatchups()
        {

            int r = 0;
            if (int.TryParse(ddRound.SelectedItem.ToString().Substring(ddRound.SelectedItem.ToString().IndexOf(' ') + 1), out r))
            {
                List<MatchupModel> currRound = new List<MatchupModel>();
                foreach (List<MatchupModel> round in tournament.Rounds)
                {
                    if (round.First().MatchupRound == r)
                    {
                        foreach(MatchupModel m in round)
                        {
                            // TODO - check logic after implementing winner
                            //&& m.DisplayName.CompareTo($"Awaiting results from Round {r - 1}") != 0
                            if (r == 1)
                            {
                                if ((m.Winner == null || !cbUnplayedOnly.Checked)) currRound.Add(m);
                            }
                            else
                            {
                                if ((m.Winner == null || !cbUnplayedOnly.Checked)) currRound.Add(m);
                            }
                        }
                        selectedMatchups = currRound;
                    }
                }
            }
            DisplayMatchupInfo();
            WireUpMatchupsLists();
        }
        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);
            teamOneName.Visible = isVisible;
            teamTwoName.Visible = isVisible;
            tbTeamOneScore.Visible = isVisible;
            tbTeamTwoScore.Visible = isVisible;
            lblTeamOneScore.Visible = isVisible;
            lblTeamTwoScore.Visible = isVisible;
            lblVS.Visible = isVisible;
            btnScore.Visible = isVisible;
        }
        private void DdRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }
        private void LoadMatchup()
        {
            teamOneName.Text = "Not Yet Determined";
            teamTwoName.Text = "Not Yet Determined";
            MatchupModel m = (MatchupModel)lbMatchup.SelectedItem;
            if(m != null)
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (m.Entries[i].TeamCompeting != null)
                    {
                        if (i == 0)
                        {
                            teamOneName.Text = m.Entries[i].TeamCompeting.TeamName;
                            tbTeamOneScore.Text = m.Entries[i].Score.ToString();
                            teamTwoName.Text = "bye";
                            tbTeamTwoScore.Text = "0";

                        }
                        if (i == 1)
                        {
                            teamTwoName.Text = m.Entries[i].TeamCompeting.TeamName;
                            tbTeamTwoScore.Text = m.Entries[i].Score.ToString();
                        }
                    }

                }
            }
            
        }
        private void LbMatchup_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }

        private void CbUnplayedOnly_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void BtnScore_Click(object sender, EventArgs e)
        {
            MatchupModel m = (MatchupModel)lbMatchup.SelectedItem;
            if (m != null)
            {
                    for (int i = 0; i < m.Entries.Count; i++)
                    {
                        bool scoreValid;
                        if (m.Entries[i].TeamCompeting != null)
                        { 
                            if (i == 0)
                            {
                                scoreValid = double.TryParse(tbTeamOneScore.Text, out double score);
                                if (scoreValid)
                                {
                                    m.Entries[i].Score = score;
                                }
                                else
                                {
                                MessageBox.Show($"Please enter a valid score for team {i + 1}");
                                return;
                                }

                            }
                            if (i == 1)
                            {
                                scoreValid = double.TryParse(tbTeamTwoScore.Text, out double score);
                                if (scoreValid)
                                {
                                    m.Entries[i].Score = score;
                                }
                                else
                                {
                                    MessageBox.Show($"Please enter a valid score for team {i + 1}");
                                    return;
                                }
                            }
                        }
                  
                    }

                // Highscore wins
                TournamentLogic.UpdateTournamentResults(tournament);
            }

            

            LoadMatchups();
        }

    }
}
