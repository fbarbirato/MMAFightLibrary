using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMAFightLibrary.Domain
{
    public class Event
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public string City { get; set; }
        public Country Country { get; set; }
        public int Attendance { get; set; }
    }
}
