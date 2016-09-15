using System.Collections.Generic;
using System.IO;
using System.Xml;
using WorldStamper.Sources.Interfaces;
using WorldStamper.Sources.Models;

namespace WorldStamper.Sources.Utilities
{
    class ResourceUtils
    {
        internal enum AssetsType
        {
            Root,
            Fonts,
            Gfx,
            Gui,
            Map,
            Sounds
        }

        internal const string ASSETS_PATH = "..\\assets";

        internal static string GetResourcePath(AssetsType type) {
            switch (type)
            {
                case AssetsType.Root:
                    return ASSETS_PATH;

                case AssetsType.Map:
                    return Path.Combine(ASSETS_PATH, "Maps");

                case AssetsType.Gfx:
                    return Path.Combine(ASSETS_PATH, "Gfx");
                
                default:
                    return null;
            }
        }

        internal static List<IResource> LoadResources()
        {
            var resources = new List<IResource>();

            var file = Path.Combine(GetResourcePath(AssetsType.Root), "assets.xml");

            if (File.Exists(file))
            {
                var xml = new XmlDocument();
                xml.Load(file);

                if (xml.ChildNodes.Count != 0)
                {
                    var assetsNode = xml.ChildNodes[0].ChildNodes;
                    foreach (XmlNode assetNode in assetsNode)
                    {
                        IResource resource = null;

                        switch (assetNode.Name.ToLower())
                        {
                            case "fonts":
                                break;

                            case "textures":
                                break;

                            case "sprites":
                                resource = Tileset.ParseFile(Path.Combine(GetResourcePath(AssetsType.Gfx), assetNode.Attributes["name"].Value));
                                break;

                            case "map":
                                resource = Map.ParseFile(Path.Combine(GetResourcePath(AssetsType.Map), assetNode.Attributes["name"].Value));
                                break;

                            case "gui":
                                break;
                        }

                        if (resource != null) resources.Add(resource);
                    }
                }
            }

            return resources;
        }

        internal static void SaveResources(IResource[] resources)
        {

        }
    }
}
