using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentTask3Server.Models
{
    public class HighScore
    {
        public long Id { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}
