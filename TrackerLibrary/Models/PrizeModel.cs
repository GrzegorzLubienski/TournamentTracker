using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the unique Id of the prize 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the place number (1st, 2nd etc. but without sufixes) for which the prize is given
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name of the place ( Winner, Runner-up etc.)
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents prize amount for the place taken, when the prizes are flat amounts
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents prize amount for the place taken, when the prizes are percentages of tournament pool
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
