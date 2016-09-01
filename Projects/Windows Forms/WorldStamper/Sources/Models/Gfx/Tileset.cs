using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;
using WorldStamper.Sources.Utilities;

namespace WorldStamper.Sources.Models
{
    class Tileset
    {
        public string Name { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();

        internal static Tileset ParseFile(string fileName)
        {
            Tileset tileset = null;

            if (File.Exists(fileName))
            {
                var xml = new XmlDocument();
                xml.Load(fileName);

                tileset = new Tileset()
                {
                    Name = Path.GetFileNameWithoutExtension(fileName)
                };

                // Tileset->Images
                foreach (XmlNode imageNode in xml.ChildNodes[0].ChildNodes)
                {
                    var image = new Image()
                    {
                        SpriteWidth = int.Parse(imageNode.Attributes["width"].Value),
                        SpriteHeight = int.Parse(imageNode.Attributes["height"].Value)
                    };

                    var file = new Bitmap(Path.Combine(ResourceUtils.GetResourcePath(ResourceUtils.AssetsType.Gfx), imageNode.Attributes["file"].Value));

                    foreach(XmlNode spriteNode in imageNode.ChildNodes)
                    {
                        var sprite = new Sprite()
                        {
                            ID = int.Parse(spriteNode.Attributes["id"].Value),
                            X = int.Parse(spriteNode.Attributes["x"].Value),
                            Y = int.Parse(spriteNode.Attributes["y"].Value),
                            Frames = int.Parse(spriteNode.Attributes["frames"].Value)
                        };

                        sprite.Texture = GraphicUtils.Cut(image.SpriteWidth * sprite.X, image.SpriteHeight * sprite.Y, 
                            image.SpriteWidth, image.SpriteHeight, file);

                        image.Sprites.Add(sprite);
                    }

                    tileset.Images.Add(image);
                }
            }

            return tileset;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
