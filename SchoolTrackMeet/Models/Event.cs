using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolTrackMeet.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public int NumContestants { get; set; }
        public int NumAlternates { get; set; }
    }
}
