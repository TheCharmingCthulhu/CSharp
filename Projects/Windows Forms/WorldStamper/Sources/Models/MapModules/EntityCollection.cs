using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;
using WorldStamper.Sources.Extensions;
using WorldStamper.Sources.Interfaces;
using WorldStamper.Sources.Utilities;

namespace WorldStamper.Sources.Models.MapModules
{
    class EntityCollection : IResource
    {
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

        #region <- File Parsing ->
        public void LoadFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                var xml = new XmlDocument();
                xml.Load(fileName);

                foreach (XmlNode entityNode in xml.ChildNodes[0].ChildNodes)
                    if (entityNode.Name.ToLower().Equals("object"))
                    {
                        var entity = new Entity() { ID = int.Parse(entityNode.Attributes["id"].Value) };

                        var texture = new Bitmap(Path.Combine(ResourceUtils.GetResourcePath(ResourceUtils.AssetsType.Gfx),
                                                entityNode.Attributes["texture"].Value));

                        foreach (XmlNode spriteNode in entityNode.ChildNodes)
                            if (spriteNode.Name.ToLower().Equals("sprite"))
                            {
                                var sprite = new Sprite()
                                {
                                    Name = spriteNode.Attributes["name"].Value,
                                };

                                sprite.Texture = GraphicsUtils.Cut(spriteNode.ChildNodes[0].Attributes["x"].ToValue<int>(),
                                                                  spriteNode.ChildNodes[0].Attributes["y"].ToValue<int>(),
                                                                  spriteNode.Attributes["width"].ToValue<int>(),
                                                                  spriteNode.Attributes["height"].ToValue<int>(),
                                                                  texture);
                            }
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
            return null;
        }
    }
}
