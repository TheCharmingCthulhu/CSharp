using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using WorldStamper.Sources.Interfaces;
using WorldStamper.Sources.Utilities;

namespace WorldStamper.Sources.Models
{
    class Map : IResource, ICopy
    {
        Map _original;

        public int ID { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public System.Drawing.Point Spawn { get; set; }
        public List<Tileset> Tilesets { get; set; } = new List<Tileset>();
        public List<Tile> Tiles { get; set; } = new List<Tile>();

        public Map()
        {

        }

        #region <- Duplicating ->
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
            if (HasUpdatedTiles() || HasUpdateTilesets()) return true;

            return  !(_original.ID == ID &&
                    _original.Name.Equals(Name) &&
                    _original.Width == Width &&
                    _original.Height == Height &&
                    _original.Spawn == Spawn);
        }

        private bool HasUpdatedTiles()
        {
            foreach (var tile in Tiles)
                if (!_original.Tiles.Contains(tile))
                    return true;

            return false;
        }

        private bool HasUpdateTilesets()
        {
            foreach (var tileset in Tilesets)
                if (!_original.Tilesets.Contains(tileset))
                    return true;

            return false;
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
            var xml = new XmlDocument();
            xml.Load(fileName);

            // Map
            var mapNode = xml.ChildNodes[0];
            ID = int.Parse(mapNode.Attributes["id"].Value);
            Name = mapNode.Attributes["name"].Value;
            Width = int.Parse(mapNode.Attributes["width"].Value);
            Height = int.Parse(mapNode.Attributes["height"].Value);

            // Map->Tilesets
            var tilesetsNode = mapNode.ChildNodes[0];
            foreach (XmlNode tilesetNode in tilesetsNode.ChildNodes)
            {
                var tileset = Tileset.ParseFile(Path.Combine(ResourceUtils.GetResourcePath(ResourceUtils.AssetsType.Gfx),
                                                tilesetNode.Attributes["file"].Value));

                Tilesets.Add(tileset);
            }

            // Map->Objects

            // Map->Overlays

            // Map->Transitions

            // Map->Spawn
            Spawn = new System.Drawing.Point(int.Parse(mapNode.ChildNodes[4].Attributes["x"].Value), int.Parse(mapNode.ChildNodes[4].Attributes["y"].Value));

            // Map->Tiles
            foreach (XmlNode node in mapNode.ChildNodes)
                if (node.Name.Equals("tile"))
                {
                    var tile = new Tile()
                    {
                        X = int.Parse(node.Attributes["x"].Value),
                        Y = int.Parse(node.Attributes["y"].Value),
                        Sprite = FindSpriteByID(int.Parse(node.Attributes["spriteid"].Value))
                    };

                    Tiles.Add(tile);
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
    }
}
