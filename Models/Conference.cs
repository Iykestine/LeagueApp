using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApp.Models
{
    public class Conference
    {
        public string LeagueId { get; set; }
        public string ConferenceId { get; set; }
        public string Name { get; set; }

        public League League { get; set; }
    }
}
