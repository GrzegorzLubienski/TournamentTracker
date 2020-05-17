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
    public partial class CreateTournamentForm : Form, IPrizeRequestor,ITeamRequestor
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            ddSelectTeam.DataSource = null;
            lbTournamentTeams.DataSource = null;
            lbPrizes.DataSource = null;

            ddSelectTeam.DataSource = availableTeams;
            ddSelectTeam.DisplayMember = "TeamName";

            lbTournamentTeams.DataSource = selectedTeams;
            lbTournamentTeams.DisplayMember = "TeamName";

            lbPrizes.DataSource = selectedPrizes;
            lbPrizes.DisplayMember = "PlaceName";
        }

        private void BtnAddTeam_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)ddSelectTeam.SelectedItem;
            if (p != null)
            {
                availableTeams.Remove(p);
                selectedTeams.Add(p);

                WireUpLists();
            }
        }

        private void BtnCreatePrize_Click(object sender, EventArgs e)
        {
            //Call the create prize form
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
            
        }

        private void LlCreateNewTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }
        public void PrizeComplete(PrizeModel model)
        {
            //getback from the prize model
            //put the model on the list
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void BtnRemoveSelectedTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)lbTournamentTeams.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void BtnRemoveSelectedPrize_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)lbPrizes.SelectedItem;
            if (p!= null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();
            }
        }

        private void BtnCreateTournament_Click(object sender, EventArgs e)
        {
            // validate data
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(tbEntryFee.Text, out fee);

            if(!feeAcceptable)
            {
                MessageBox.Show("You need to enter valid entry fee",
                    "Invalid fee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            //create tournament model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tbTournamentName.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            //create matchups
            TournamentLogic.CreateRounds(tm);

            //create tournament entry
            //create all of prizes entrie
            //create all of team entries
            GlobalConfig.Connection.CreateTournament(tm);

            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
            this.Close();


        }
    }
}
