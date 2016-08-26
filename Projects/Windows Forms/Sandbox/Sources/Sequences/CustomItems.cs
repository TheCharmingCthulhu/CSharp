using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Sources.Sequences
{
    class CustomItems
    { 
        public class CustomItem
        {
            public int Start { get; set; }
            public int Duration { get; set; }
            public int Type { get; set; }
        }

        public List<CustomItem> Items { get; set; }
    }
}
