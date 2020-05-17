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
    public partial class CreateTeamForm : Form
    {
        private ITeamRequestor callingForm;
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm(ITeamRequestor caller)
        {
            InitializeComponent();
            callingForm = caller;
            //CreateSampleData();
            WireUpLists();
        }
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Greg", LastName = "Lub" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Mike", LastName = "Wazowski" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Peter", LastName = "Parker" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Tony", LastName = "Stark" });
        }

        private void WireUpLists()
        {
            ddSelectTeamMember.DataSource = null;
            ddSelectTeamMember.DataSource = availableTeamMembers;
            ddSelectTeamMember.DisplayMember = "FullName";

            lbTeamMembers.DataSource = null;
            lbTeamMembers.DataSource = selectedTeamMembers;
            lbTeamMembers.DisplayMember = "FullName";
        }

        private void BtnCreateMember_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = tbFirstName.Text;
                p.LastName = tbLastName.Text;
                p.EmailAddress = tbEmail.Text;
                p.CellphoneNumber = tbCellphone.Text;

                GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                WireUpLists();

                tbFirstName.Text = "";
                tbLastName.Text = "";
                tbEmail.Text = "";
                tbCellphone.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields");
            }
            
        }

        private bool ValidateForm()
        {

            //TODO - add more robust validation of the form
            if (tbFirstName.Text.Length == 0)
            {
                return false;
            }

            if (tbLastName.Text.Length == 0)
            {
                return false;
            }

            if (tbEmail.Text.Length == 0)
            {
                return false;
            }

            if (tbCellphone.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void BtnAddTeamMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)ddSelectTeamMember.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void BtnRemoveSelectedTeamMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)lbTeamMembers.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void BtnCreateTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = tbTeamName.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);
            callingForm.TeamComplete(t);
            this.Close();
            
        }
    }
}
