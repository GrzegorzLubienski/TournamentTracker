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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequestor callingForm;
        public CreatePrizeForm(IPrizeRequestor caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void BtnCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    tbPlaceName.Text,
                    tbPlaceNumber.Text, 
                    tbPrizeAmount.Text, 
                    tbPrizePercentage.Text);

                GlobalConfig.Connection.CreatePrize(model);
                callingForm.PrizeComplete(model);
                this.Close();
                //tbPlaceName.Text = "";
                //tbPlaceNumber.Text = "";
                //tbPrizeAmount.Text = "0";
                //tbPrizePercentage.Text = "0";
            }

            else
            {
                MessageBox.Show("This box has invalid information, please check it and try again");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(tbPlaceNumber.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                // TODO - add managing of incorrect input for place number
                output = false;
            }

            if(placeNumber<1)
            {
                // TODO - add managing of incorrect input for place number
                output = false;
            }

            if(tbPlaceName.Text.Length == 0)
            {
                // TODO - add managing of incorrect input for place name
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(tbPrizeAmount.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(tbPrizePercentage.Text, out prizePercentage);

            if(!prizeAmountValid || !prizePercentageValid)
            {
                // TODO - add managing of incorrect input for prize amount or percentage
                output = false;
            }

            if(prizeAmount <=0 && prizePercentage <= 0)
            {
                // TODO - add managing of incorrect input for prize amount && percentage
                output = false;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                // TODO - add managing of incorrect input for prize percentage
                output = false;
            }



            return output;
        }
    }
}
