using AssessmentTask3Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentTask3Server.DbContexts
{
    public class DbContexts
    {
        public class HighScoreDbContext : DbContext
        {
            public HighScoreDbContext(DbContextOptions<HighScoreDbContext> options) : base(options)
            {
            }

            public DbSet<HighScore> HighScores { get; set; }
        }
    }
}
