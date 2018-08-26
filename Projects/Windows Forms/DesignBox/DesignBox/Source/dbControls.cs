using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DesignBox.Source
{
    public class DBControls
    {
        const string DB_NAMESPACE_CONTROLS = "DesignBox.Source.Controls";

        public static List<DBControl> GetCustomControls()
        {
            List<DBControl> controls = new List<DBControl>();

            // Suche nach allen "UserControl" unter angegebenen namespace ..
            Type[] classes = Assembly.GetCallingAssembly().GetTypes()
                .Where(x => x.Namespace.Equals(DB_NAMESPACE_CONTROLS))
                .ToArray();

            foreach (Type classtype in classes)
            {
                if (classtype.IsSubclassOf(typeof(UserControl)))
                {
                    controls.Add(new DBControl(classtype));
                }
            }

            return controls;
        }
    }
}
