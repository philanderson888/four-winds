﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leaderboard.Models
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions options) : base(options) { }
        public GameDbContext() { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(user => user.Property(u => u.UserId).IsRequired());
            builder.Entity<User>().HasData(
                new User { UserId = 1, Username = "mikea", FirstName = "Mike", LastName = "Adrianos", 
                    Winnings = 1478000.00, Country = "USA", 
                    Thumbnail = "https://www.johnsonlambert.com/wp-content/uploads/2017/10/lanemiller-thumbnail-750x750.png"
                },
                new User { UserId = 2, Username = "joeb", FirstName = "Joe", LastName = "Brimano", Winnings = 2348000.00, Country = "USA", 
                    Thumbnail = "data:image/jpeg;base64,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"
                },
                new User { UserId = 3, Username = "andreac", FirstName = "Andrea", LastName = "Caratti", Winnings = 5793000.00, Country = "USA", 
                    Thumbnail = "https://www.attractivepartners.co.uk/wp-content/uploads/2017/06/profile.jpg"
                }
            );
        }
    }
}
