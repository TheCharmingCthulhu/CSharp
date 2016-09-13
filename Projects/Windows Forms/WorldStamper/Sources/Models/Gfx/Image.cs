using System.Collections.Generic;

namespace WorldStamper.Sources.Models
{
    class Image
    {
        public string Name { get; set; }
        public int SpriteWidth { get; set; }
        public int SpriteHeight { get; set; }
        public List<Sprite> Sprites { get; set; } = new List<Sprite>();

        public override string ToString()
        {
            return string.Format("{0} - {1} Sprites", Name, Sprites.Count);
        }

        public override bool Equals(object obj)
        {
            if (obj is Image)
            {
                var image = obj as Image;

                return image.Name.Equals(Name) &&
                        image.SpriteWidth == SpriteWidth &&
                        image.SpriteHeight == SpriteHeight &&
                        HasEqualCollections(obj);
            }

            return false;
        }

        private bool HasEqualCollections(object obj)
        {
            if (obj is Image)
            {
                var image = obj as Image;

                foreach (var sprite in image.Sprites)
                    if (!Sprites.Contains(sprite))
                        return false;

                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
