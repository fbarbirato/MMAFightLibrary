using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMAFightLibrary.Domain
{
    public class Match
    {
        public long Id { get; set; }
        public int OrderNumber { get; set; }
        public bool IsChampionship { get; set; }
        public Fighter FighterBlue { get; set; }
        public Fighter FighterRed { get; set; }
        public WeightClass WeightClass { get; set; }
    }
}
