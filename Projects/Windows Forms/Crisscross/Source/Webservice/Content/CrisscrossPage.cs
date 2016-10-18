using Crisscross.Source.Webservice.Content.Interfaces;
using System;
using System.Reflection;

namespace Crisscross.Source.Webservice.Content
{
    class CrisscrossPage
    {
        ICrisscrossContent _context;
        MethodInfo _content;

        public CrisscrossPageInfo PageInfo { get; set; }

        public CrisscrossPage(ICrisscrossContent context, MethodInfo content)
        {
            _context = context;
            _content = content;
        }

        public string Execute()
        {
            return _content.ReturnType.Equals(typeof(string)) ? (string)_content.Invoke(_context, null) : "";    
        }
    }
}
