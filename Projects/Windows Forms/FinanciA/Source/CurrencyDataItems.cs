using System.Drawing;

namespace FinanciA.Source
{
    public class CurrencyDataItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Bitmap Icon { get; set; }
    }

    public class Fixcost : CurrencyDataItem
    {

    }

    public class Salary : CurrencyDataItem
    {

    }
}
