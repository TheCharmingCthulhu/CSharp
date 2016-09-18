using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldStamper.Sources.Interfaces
{
    interface ICompare
    {
        /// <summary>
        /// Checks two resources for equality.
        /// </summary>
        bool IsEqual<IResource>(IResource resource);
    }
}
