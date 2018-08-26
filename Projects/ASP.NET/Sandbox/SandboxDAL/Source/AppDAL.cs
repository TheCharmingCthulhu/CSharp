using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using SandboxBLL.Source.VO;

namespace SandboxDAL.Source
{
    public class AppDAL
    {
        const string PATH = "";

        public List<AppVO> Load()
        {
            List<AppVO> items = new List<AppVO>();

            if (Directory.Exists(PATH)) {
                var files = Directory.GetFiles(PATH);
                var doc = new XmlDocument();
                var app = new AppVO();

                foreach(var file in files)
                {
                    doc.Load(file);

                    foreach(XmlNode node in doc.ChildNodes)
                    {
                        if(node.Name.ToLower().Equals("id"))
                            app.ID = Convert.ToInt32(node.Value);
                        if (node.Name.ToLower().Equals("name"))
                            app.Name = node.Value;
                        if (node.Name.ToLower().Equals("version"))
                            app.Version = node.Value;
                    }
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
