using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMAFightLibrary.Domain
{
    public class Fighter
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public WeightClass CurrentWeightClass { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public Country BirthCountry { get; set; }
        public List<Match> Fights { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int NoContests { get; set; }
    }
}
