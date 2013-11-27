using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMAFightLibrary.Domain
{
    public class Promotion
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public readonly List<Event> Events;
    }
}
