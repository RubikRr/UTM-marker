using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTM_marker
{
    internal class Website
    {
        public string Name { get; }
        public UtmLink UTMparam { get; }

        public Website(string name, UtmLink utmParam)
        {
            Name = name;
            UTMparam = utmParam;
        }
    }
}
