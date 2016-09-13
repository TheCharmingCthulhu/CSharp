using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;
using WorldStamper.Sources.Extensions;
using WorldStamper.Sources.Interfaces;
using WorldStamper.Sources.Utilities;

namespace WorldStamper.Sources.Models
{
    class Tileset : IResource
    {
        public string Filename { get; set; }
        public string Name { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();

        public override string ToString()
        {
            return Name;
        }

        #region <- File Parsing ->
        internal static Tileset ParseFile(string fileName)
        {
            var tileset = new Tileset();
            tileset.LoadFile(fileName);

            return tileset;
        }

        public void LoadFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                var xml = new XmlDocument();
                xml.Load(fileName);

                Filename = Path.GetFileName(fileName);
                Name = Path.GetFileNameWithoutExtension(fileName);

                // Tileset->Images
                foreach (XmlNode imageNode in xml.ChildNodes[0].ChildNodes)
                    if (imageNode.Name.ToLower().Equals("image"))
                    {
                        var image = new Image()
                        {
                            Name = imageNode.Attributes["file"].Value,
                            SpriteWidth = imageNode.Attributes["width"].ToValue<int>(),
                            SpriteHeight = imageNode.Attributes["height"].ToValue<int>()
                        };

                        var texture = new Bitmap(Path.Combine(ResourceUtils.GetResourcePath(ResourceUtils.AssetsType.Gfx),
                                                           imageNode.Attributes["file"].Value));

                        foreach (XmlNode spriteNode in imageNode.ChildNodes)
                            if (spriteNode.Name.ToLower().Equals("sprite"))
                            {
                                var sprite = new Sprite()
                                {
                                    ID = spriteNode.Attributes["id"].ToValue<int>(),
                                    X = spriteNode.Attributes["x"].ToValue<int>(),
                                    Y = spriteNode.Attributes["y"].ToValue<int>(),
                                    Frames = spriteNode.Attributes["frames"].ToValue<int>()
                                };

                                sprite.Texture = GraphicsUtils.Cut(image.SpriteWidth * sprite.X, image.SpriteHeight * sprite.Y,
                                    image.SpriteWidth, image.SpriteHeight, texture);

                                image.Sprites.Add(sprite);
                            }

                        Images.Add(image);
                    }
            }
        }

        public void SaveFile(string fileName)
        {
            throw new NotImplementedException();
        }
        #endregion

        public void Copy()
        {

        }

        public bool HasChanges()
        {
            return false;
        }

        public bool IsEqual<IResource>(IResource resource)
        {
            return false;
        }
    }
}
