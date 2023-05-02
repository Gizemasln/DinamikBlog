using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Match
    {
        [Key]
        public int MatchID { get; set; }
        public int? HomeTeamID { get; set; }
        public int? GuesTeamID { get; set; }
        public string? MatchaDate { get; set; }
        public string? Stadium { get; set; }
        public Team? HomeTeam { get; set; }
        public Team? GuesTeam { get; set; }
    }
}
