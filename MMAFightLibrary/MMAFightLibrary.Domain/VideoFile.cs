using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMAFightLibrary.Domain
{
    public class VideoFile
    {
        public long Id { get; set; }
        public string Path { get; set; }
        public long StartTime { get; set; }
        public long EndTime { get; set; }
        public long Duration 
        {
            get { return EndTime - StartTime; }
        }
    }
}
