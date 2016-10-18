using System;
namespace Crisscross.Source.Webservice.Content
{
    public class CrisscrossPageInfo : Attribute
    {
        public string URI { get; }

        public CrisscrossPageInfo(string address)
        {
            URI = address;
        }
    }
}
