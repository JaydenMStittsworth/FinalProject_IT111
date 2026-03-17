using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_IT111
{
    public class Record
    {
        public string Title { get; set; }
        public string Entry { get; set; }


        public Record(string title, string entry)
        {
            Title = title;
            Entry = entry;
        }

        public Record()
        {
            Title = "";
            Entry = "";
        }

        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
