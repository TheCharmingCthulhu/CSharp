using SandboxThreeTier.Source.VO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Xml;

namespace SandboxThreeTier.Source.DAL
{
    public class AppDAL
    {
        const string DIRECTORY_PATH = "SandboxData";

        public List<AppVO> Load()
        {
            List<AppVO> items = new List<AppVO>();

            string path = string.Format("{0}\\{1}", Directory.GetParent(HttpRuntime.AppDomainAppPath).Parent.FullName, DIRECTORY_PATH);

            if (Directory.Exists(path)) {
                var files = Directory.GetFiles(path);
                var doc = new XmlDocument();

                foreach (var file in files)
                {
                    var app = new AppVO();

                    doc.Load(file);

                    foreach(XmlNode node in doc.ChildNodes[1])
                    {
                        if(node.Name.ToLower().Equals("id"))
                            app.ID = Convert.ToInt32(node.InnerText);
                        if (node.Name.ToLower().Equals("name"))
                            app.Name = node.InnerText;
                        if (node.Name.ToLower().Equals("version"))
                            app.Version = node.InnerText;
                    }

                    items.Add(app);
                }
            }

            return items;
        }

        public void Save(AppVO value)
        {
            throw new NotImplementedException();
        }
    }
}
