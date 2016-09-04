﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using WorldStamper.Sources.Interfaces;
using WorldStamper.Sources.Utilities;

namespace WorldStamper.Sources.Models
{
    class Map : IResource
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Tileset> Tilesets { get; set; } = new List<Tileset>();
        public List<Tile> Tiles { get; set; } = new List<Tile>();

        #region <- File Parsing ->
        internal static Map ParseFile(string fileName)
        {
            var map = new Map();
            map.LoadFile(fileName);

            return map;
        }

        public void LoadFile(string fileName)
        {
            switch (Path.GetExtension(fileName).ToLower())
            {
                case ".xml":
                    LoadFileAsXML(fileName);
                    break;
            }
        }

        private void LoadFileAsXML(string fileName)
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
            switch (Path.GetExtension(fileName).ToLower())
            {
                case ".xml":

                    break;
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
    }
}
