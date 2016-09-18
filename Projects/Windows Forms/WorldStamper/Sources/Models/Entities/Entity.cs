using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using WorldStamper.Sources.Interfaces;
using WorldStamper.Sources.Utilities;

namespace WorldStamper.Sources.Models.Entities
{
    class Entity : IResource
    {
        public int ID { get; set; }
        public string Filename { get; set; }
        public string Name { get { return Path.GetFileNameWithoutExtension(Filename); }}
        public List<Sprite> Sprites { get; set; } = new List<Sprite>();
        public List<Template> Templates { get; set; } = new List<Template>();

        public bool IsEqual<IResource>(IResource resource)
        {
            if (resource is Entity)
            {
                var entity = resource as Entity;

                foreach (var sprite in entity.Sprites)
                    if (!Sprites.Contains(sprite))
                        return false;

                foreach (var template in entity.Templates)
                    if (!Templates.Contains(template))
                        return false;

                return entity.ID != ID &&
                       entity.Filename != Filename &&
                       entity.Sprites.Count != Sprites.Count;
            }

            return false;
        }

        public string GetFilename()
        {
            return Filename;
        }

        public IResource Copy()
        {
            throw new NotImplementedException();
        }

        public bool HasChanges()
        {
            throw new NotImplementedException();
        }

        public Sprite GetSpriteByName(string spriteName)
        {
            return Sprites.FirstOrDefault(s => s.Name.Equals(spriteName));
        }

        public Bitmap GetTemplateImage(string templateName)
        {
            var template = Templates.FirstOrDefault(t => t.Name.Equals(templateName));

            if (template != null)
            {
                int width = 0, height = 0;
                var sprites = new List<Sprite>();

                foreach (var layer in template.Layers)
                {
                    var sprite = GetSpriteByName(layer.Name);

                    if (width < sprite.X)
                    {
                        width += sprite.X;
                        width += sprite.Texture.Width;
                    }

                    if (width < sprite.Texture.Width)
                        width = sprite.Texture.Width;

                    if (height < sprite.Y)
                    {
                        height += sprite.Y;
                        height += sprite.Texture.Height;
                    }

                    if (height < sprite.Texture.Height)
                        height = sprite.Texture.Height;

                    sprites.Add(sprite);
                }

                return GraphicsUtils.Merge(width, height, sprites.ToArray());
            }

            return null;
        }

        public void LoadFile(string fileName)
        {
            throw new NotImplementedException();
        }

        public void SaveFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
