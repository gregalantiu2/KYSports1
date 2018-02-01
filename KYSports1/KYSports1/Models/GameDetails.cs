using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KYSports1.Models
{
    public class GameDetails
    {
        public string Opponent { get; set; }
        public string DayOfWeek { get; set; }
        public DateTime GameDate { get; set; }
        public string Network { get; set; }
        public string GameLocation { get; set; }
    }
}