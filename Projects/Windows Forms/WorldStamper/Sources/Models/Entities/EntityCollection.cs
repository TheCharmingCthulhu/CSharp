using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;
using WorldStamper.Sources.Extensions;
using WorldStamper.Sources.Interfaces;
using WorldStamper.Sources.Utilities;

namespace WorldStamper.Sources.Models.Entities
{
    class EntityCollection : IResource
    {
        public string Filename { get; set; }
        public string Name { get { return Path.GetFileNameWithoutExtension(Filename); } }
        public List<Entity> Entities { get; set; } = new List<Entity>();

        internal static EntityCollection ParseFile(string fileName)
        {
            var entityCollection = new EntityCollection();
            entityCollection.LoadFile(fileName);

            return entityCollection;
        }

        public IResource Copy()
        {
            return null;
        }

        public bool HasChanges()
        {
            return false;
        }

        private bool ValidateSpriteGroup(string name)
        {
            return name.Contains("_");
        }

        #region <- File Parsing ->
        public void LoadFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                Point spriteGroupPosition = Point.Empty;

                var xml = new XmlDocument();
                xml.Load(fileName);

                Filename = Path.GetFileName(fileName);

                foreach (XmlNode entityNode in xml.ChildNodes[0].ChildNodes)
                    if (entityNode.Name.ToLower().Equals("object"))
                    {
                        var entity = new Entity() { ID = int.Parse(entityNode.Attributes["id"].Value),
                            Filename = entityNode.Attributes["texture"].Value };

                        var texture = new Bitmap(Path.Combine(ResourceUtils.GetResourcePath(ResourceUtils.AssetsType.Gfx),
                                                entityNode.Attributes["texture"].Value));

                        foreach (XmlNode spriteNode in entityNode.ChildNodes)
                            if (spriteNode.Name.ToLower().Equals("sprite"))
                            {
                                if (ValidateSpriteGroup(spriteNode.Attributes["name"].Value))
                                {
                                    if (spriteNode.Attributes["name"].Value.Split('_')[1] == "a")
                                        spriteGroupPosition = new Point(spriteNode.ChildNodes[0].Attributes["x"].ToValue<int>(), spriteNode.ChildNodes[0].Attributes["y"].ToValue<int>());
                                }
                                else spriteGroupPosition = new Point(spriteNode.ChildNodes[0].Attributes["x"].ToValue<int>(), spriteNode.ChildNodes[0].Attributes["y"].ToValue<int>());

                                var sprite = new Sprite()
                                {
                                    Name = spriteNode.Attributes["name"].Value,
                                    X = spriteGroupPosition.X,
                                    Y = spriteGroupPosition.Y,
                                };

                                sprite.Texture = GraphicsUtils.Cut(spriteNode.ChildNodes[0].Attributes["x"].ToValue<int>(),
                                                                   spriteNode.ChildNodes[0].Attributes["y"].ToValue<int>(),
                                                                   spriteNode.Attributes["width"].ToValue<int>(),
                                                                   spriteNode.Attributes["height"].ToValue<int>(), texture);

                                entity.Sprites.Add(sprite);
                            }

                        var drawNode = entityNode.ChildNodes.FindNode("draw");
                        foreach (XmlNode variationNode in drawNode.ChildNodes)
                        {
                            var template = new Template() {
                                Name = variationNode.Attributes["name"].Value,  
                            };

                            foreach (XmlNode layerNode in variationNode.ChildNodes)
                            {
                                var layer = new Layer()
                                {
                                    Name = layerNode.Attributes["name"].Value,
                                    Offset = new Point(layerNode.Attributes["xoffset"].ToValue<int>(), layerNode.Attributes["yoffset"].ToValue<int>()),
                                };

                                if (layerNode.Name.ToLower().Equals("background"))
                                    layer.Level = Layer.LevelType.Background;
                                else if (layerNode.Name.ToLower().Equals("foreground"))
                                    layer.Level = Layer.LevelType.Foreground;

                                template.Layers.Add(layer);
                            }

                            entity.Templates.Add(template);
                        }

                        Entities.Add(entity);
                    }
            }
        }

        public void SaveFile(string fileName)
        {
            throw new NotImplementedException();
        } 
        #endregion


        public bool IsEqual<IResource>(IResource resource)
        {
            if (resource is EntityCollection)
            {
                var entityCollection = resource as EntityCollection;

                if (entityCollection.Entities.Count != Entities.Count) return false;

                foreach (var entity in entityCollection.Entities)
                    if (!Entities.Contains(entity))
                        return false;

                return true;
            }

            return false;
        }

        public string GetFilename()
        {
            return Filename;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
