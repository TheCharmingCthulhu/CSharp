using System.Reflection;

namespace Crisscross.Source.Webservice.Content.Interfaces
{
    interface ICrisscrossContent
    {
        void SetPages();
        CrisscrossPage[] GetPages();
        CrisscrossPage GetPage(string uri);
    }
}
