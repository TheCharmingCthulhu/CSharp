using FSync.Sources;
using System;
using System.IO;
using System.Xml;
using WinSCP;

namespace FSync.Sources
{
    class SyncStorage
    {
        private const string STORAGE_PATH = "\\Data\\";

        private static string GetFilePath(string fileName)
        {
            return string.Format("{0}{1}{2}.xml", Environment.CurrentDirectory, STORAGE_PATH, fileName);
        }

        #region <- Credential Storage ->
        internal static void SaveCredentials(SessionOptions credentials)
        {
            ValidateStorage(credentials.HostName);

            var xml = new XmlDocument();
            using (var writer = XmlWriter.Create(GetFilePath(credentials.HostName), new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement(XmlConvert.EncodeName(credentials.HostName));
                writer.WriteElementString("fingerprint", XmlConvert.EncodeName(credentials.SshHostKeyFingerprint));
                writer.WriteEndElement();
                writer.WriteEndDocument();

                xml.Save(writer);
            }
        }

        internal static void LoadCredentials(SessionOptions credentials)
        {
            if (ValidateStorage(credentials.HostName))
            {
                var xml = new XmlDocument();
                xml.Load(GetFilePath(credentials.HostName));

                credentials.SshHostKeyFingerprint = XmlConvert.DecodeName(xml.ChildNodes[1].ChildNodes[0].InnerText);
            }
        }
        #endregion

        #region <- Settings Storage ->
        internal static void SaveSettings(SyncSettings settings)
        {
            ValidateStorage("settings");

            var xml = new XmlDocument();
            using (var writer = XmlWriter.Create(GetFilePath("settings"), new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("settings");
                writer.WriteElementString("Hostname", settings.Hostname);
                writer.WriteElementString("Username", settings.Username);
                writer.WriteEndElement();
                writer.WriteEndDocument();

                xml.Save(writer);
            };
        }

        internal static void LoadSettings(SyncSettings settings)
        {
            if (ValidateStorage("settings"))
            {
                var xml = new XmlDocument();
                xml.Load(GetFilePath("settings"));

                settings.Hostname = xml.ChildNodes[1].ChildNodes[0].InnerText;
                settings.Username = xml.ChildNodes[1].ChildNodes[1].InnerText;
            }
        }
        #endregion

        private static bool ValidateStorage(string fileName)
        {
            var path = GetFilePath(fileName);

            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                return false;
            }

            return File.Exists(path);
        }
    }
}
