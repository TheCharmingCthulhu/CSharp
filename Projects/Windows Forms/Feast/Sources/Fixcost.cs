using System.Drawing;
using System.Xml.Serialization;

namespace Feast.Sources
{
    public class Fixcost
    {
        public string Description { get; set; }
        public decimal Sum { get; set; }
        public string File { get; set; }

        [XmlIgnore]
        public Bitmap Icon { get; set; }
    }
}
