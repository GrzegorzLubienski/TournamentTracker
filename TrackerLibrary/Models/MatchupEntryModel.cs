using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents the unique Id of the matchup entry
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Used to determine the Id of the Team competing based on the entry from Database
        /// </summary>
        public int TeamCompetingId { get; set; }
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents score for the given Team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Used to determine the Id of the parent matchup based on the entry from Database
        /// </summary>
        public int ParentMatchupId { get; set; }
        /// <summary>
        /// Represents the matchup that this team came from as a winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
