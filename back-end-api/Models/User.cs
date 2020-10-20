using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leaderboard.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Thumbnail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Winnings { get; set; }

        public string Country { get; set; }

    }
}
