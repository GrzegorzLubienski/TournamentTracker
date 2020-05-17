using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {

        /// <summary>
        /// represents unique tournament identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents entry fee needed to enter the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the list of teams that entered the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents the list of prizes available in the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents rounds played during the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
