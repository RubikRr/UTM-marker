using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTM_marker
{
    public  class Course
    {
        public string Name { get;}
        public string Link { get; }

        public List<Website> Websites { get; set; }

        public Course(string name, string link, List<Website> websites)
        {
            Name = name;
            Link = link;
            Websites = websites;

        }
    }
}
