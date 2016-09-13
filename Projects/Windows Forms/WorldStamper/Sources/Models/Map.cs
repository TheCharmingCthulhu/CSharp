using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using WorldStamper.Sources.Extensions;
using WorldStamper.Sources.Interfaces;
using WorldStamper.Sources.Models.MapModules;
using WorldStamper.Sources.Utilities;

namespace WorldStamper.Sources.Models
{
    class Map : IResource
    {
        Map _original;

        public int ID { get; set; }
        public string Filename { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public System.Drawing.Point Spawn { get; set; }
        public List<EntityCollection> EntityCollections { get; set; } = new List<EntityCollection>();
        public List<Transition> Transitions { get; set; } = new List<Transition>();
        public List<Tileset> Tilesets { get; set; } = new List<Tileset>();
        public List<Tile> Tiles { get; set; } = new List<Tile>();

        public Map()
        {

        }

        #region <- Duplicate ->
        public void Copy()
        {
            _original = new Map()
            {
                ID = ID,
                Name = Name,
                Width = Width,
                Height = Height,
                Spawn = Spawn
            };
            _original.Tiles.AddRange(Tiles);
            _original.Tilesets.AddRange(Tilesets);
        }

        public bool HasChanges()
        {
            return !IsEqual(_original);
        }
 
        #endregion

        #region <- File Parsing ->
        internal static Map ParseFile(string fileName)
        {
            var map = new Map();
            map.LoadFile(fileName);
            map.Copy();

            return map;
        }

        public void LoadFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                Filename = fileName;

                var xml = new XmlDocument();
                xml.Load(fileName);

                // Map
                var mapNode = xml.ChildNodes[0];
                ID = mapNode.Attributes["id"].ToValue<int>();
                Name = mapNode.Attributes["name"].Value;
                Width = mapNode.Attributes["width"].ToValue<int>();
                Height = mapNode.Attributes["height"].ToValue<int>();

                // Map->Tilesets
                if (mapNode.ChildNodes.HasNode("tilesets"))
                {
                    var tilesetsNode = mapNode.ChildNodes.FindNode("tilesets");
                    foreach (XmlNode tilesetNode in tilesetsNode.ChildNodes)
                    {
                        var tileset = Tileset.ParseFile(Path.Combine(ResourceUtils.GetResourcePath(ResourceUtils.AssetsType.Gfx),
                                                        tilesetNode.Attributes["file"].Value));
                        Tilesets.Add(tileset);
                    }
                }

                // Map->Entities
                if (mapNode.ChildNodes.HasNode("objects"))
                {
                    var entityCollectionNodes = mapNode.ChildNodes.FindNode("objects");
                    foreach (XmlNode entityCollectionNode in entityCollectionNodes)
                    {
                        var entityCollection = EntityCollection.ParseFile(Path.Combine(ResourceUtils.GetResourcePath(ResourceUtils.AssetsType.Gfx),
                                                                          entityCollectionNode.Attributes["file"].Value));
                        EntityCollections.Add(entityCollection);
                    }
                }

                // Map->Transitions
                if (mapNode.ChildNodes.HasNode("transitions"))
                {
                    var transitionsNode = mapNode.ChildNodes.FindNode("transitions");
                    foreach (XmlNode transitionNode in transitionsNode.ChildNodes)
                    {
                        var transition = new Transition()
                        {
                            X = transitionNode.Attributes["x"].ToValue<int>(),
                            Y = transitionNode.Attributes["y"].ToValue<int>(),
                            Target = new Transition.TransitionTarget()
                            {
                                ID = transitionNode.ChildNodes[0].Attributes["mapid"].ToValue<int>(),
                                X = transitionNode.ChildNodes[0].Attributes["x"].ToValue<int>(),
                                Y = transitionNode.ChildNodes[0].Attributes["y"].ToValue<int>(),
                            }
                        };

                        Transitions.Add(transition);
                    }
                }

                // Map->Spawn
                if (mapNode.ChildNodes.HasNode("spawn"))
                    Spawn = new System.Drawing.Point(mapNode.ChildNodes.FindNode("spawn").Attributes["x"].ToValue<int>(), 
                                                     mapNode.ChildNodes.FindNode("spawn").Attributes["y"].ToValue<int>());

                // Map->Tiles
                foreach (XmlNode node in mapNode.ChildNodes)
                    if (node.Name.ToLower().Equals("tile"))
                    {
                        var tile = new Tile()
                        {
                            X = node.Attributes["x"].ToValue<int>(),
                            Y = node.Attributes["y"].ToValue<int>(),
                            Sprite = FindSpriteByID(node.Attributes["spriteid"].ToValue<int>())
                        };

                        Tiles.Add(tile);
                    }
            }
        }

        public void SaveFile(string fileName)
        {
            using (var writer = XmlWriter.Create(fileName, new XmlWriterSettings() { Indent = true, OmitXmlDeclaration = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("map");

                writer.WriteAttributeString("id", _original.ID.ToString());
                writer.WriteAttributeString("name", _original.Name);
                writer.WriteAttributeString("width", _original.Width.ToString());
                writer.WriteAttributeString("height", _original.Height.ToString());

                writer.WriteStartElement("tilesets");
                foreach (var tileset in _original.Tilesets)
                {
                    writer.WriteStartElement("tileset");
                    writer.WriteAttributeString("file", tileset.Filename);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteStartElement("objects");
                writer.WriteEndElement();

                writer.WriteStartElement("overlays");
                writer.WriteEndElement();

                writer.WriteStartElement("transitions");
                writer.WriteEndElement();

                writer.WriteStartElement("spawn");
                writer.WriteAttributeString("x", _original.Spawn.X.ToString());
                writer.WriteAttributeString("y", _original.Spawn.Y.ToString());
                writer.WriteEndElement();

                foreach(var tile in _original.Tiles)
                {
                    writer.WriteStartElement("tile");
                    writer.WriteAttributeString("x", tile.X.ToString());
                    writer.WriteAttributeString("y", tile.Y.ToString());
                    writer.WriteAttributeString("spriteid", tile.Sprite.ID.ToString());

                    // Tile->Scripts
                    writer.WriteStartElement("script");
                    writer.WriteEndElement();

                    // Tile->Properties

                    // Tile->Overlays

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
        #endregion

        internal Sprite FindSpriteByID(int spriteID)
        {
            foreach (var tileset in Tilesets)
                foreach (var image in tileset.Images)
                    foreach (var sprite in image.Sprites)
                        if (sprite.ID == spriteID)
                            return sprite;
            return null;
        }

        internal void ReplaceTile(int x, int y, Tile tile)
        {
            var t = GetTile(x, y);

            Tiles.Remove(t);
            Tiles.Add(tile);
        }

        internal Tile GetTile(int x, int y)
        {
            return Tiles.Find(t => t.X == x && t.Y == y);
        }

        #region <- Equality ->
        public bool IsEqual<IResource>(IResource resource)
        {
            if (resource is Map)
            {
                var map = resource as Map;

                if (map.ID == ID) return true;

                return map.Name.Equals(Name) &&
                        map.Width == Width &&
                        map.Height == Height &&
                        map.Spawn == Spawn &&
                        HasEqualCollections(resource);
            }

            return false;
        }

        private bool HasEqualCollections<IResource>(IResource resource)
        {
            bool result = false;

            if (resource is Map)
            {
                var map = resource as Map;

                foreach (var entityCollection in map.EntityCollections)
                    foreach (var item in EntityCollections)
                        if (!item.IsEqual(entityCollection))
                            return false;

                foreach (var transition in map.Transitions)
                    if (!Transitions.Contains(transition))
                        return false;

                foreach (var tileset in map.Tilesets)
                    foreach (var item in Tilesets)
                        if (!item.IsEqual(tileset))
                            return false;

                foreach (var tile in map.Tiles)
                    if (!Tiles.Contains(tile))
                        return false;

                return true;
            }

            return result;
        }
        #endregion
    }
}
