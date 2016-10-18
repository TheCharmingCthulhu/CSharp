using System.Reflection;
using System.Linq;
using Crisscross.Source.Webservice.Content.Interfaces;
using Crisscross.Source.Webservice.Content;
using System;

namespace Crisscross.Source.Service
{
    class HelloService : ICrisscrossContent
    {
        CrisscrossPage[] _pages;

        public HelloService()
        {
            SetPages();
        }

        public void SetPages()
        {
            _pages = GetType().GetMethods()
                .Where(m => m.IsDefined(typeof(CrisscrossPageInfo)))
                .Select(m => new CrisscrossPage(this, m)
                {
                    PageInfo = m.GetCustomAttribute(typeof(CrisscrossPageInfo)) as CrisscrossPageInfo
                }).ToArray();
        }

        public CrisscrossPage[] GetPages()
        {
            return _pages;
        }

        public CrisscrossPage GetPage(string uri)
        {
            return _pages.FirstOrDefault(p => p.PageInfo.URI.ToLower().Equals(uri.ToLower()));
        }

        [CrisscrossPageInfo("Index")]
        public string Index()
        {
            return "<html><head></head><body><h2>Hello World</h2></body></html>";
        }
    }
}
