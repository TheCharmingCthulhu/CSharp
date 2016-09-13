namespace WorldStamper.Sources.Models.MapModules
{
    class Tile
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Sprite Sprite { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Tile)
            {
                var tile = obj as Tile;

                return  tile.X == X &&
                        tile.Y == Y &&
                        tile.Sprite.Equals(Sprite);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
