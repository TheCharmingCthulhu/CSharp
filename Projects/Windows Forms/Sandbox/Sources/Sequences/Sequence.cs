using System.Collections.Generic;

namespace Sandbox.Sources.Sequences
{
    class Sequence
    {
        public int Duration { get; set; }

        public List<CustomItems.CustomItem> Items { get; set; } = new List<CustomItems.CustomItem>();
    }
}
