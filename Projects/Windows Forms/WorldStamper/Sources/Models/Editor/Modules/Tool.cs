namespace WorldStamper.Sources.Models.Editor.Modules
{
    class Tool
    {
        public enum DrawMode
        {
            Cursor,
            Paint,
            Entity
        }

        public DrawMode Mode { get; set; } = DrawMode.Cursor;
        public Sprite Sprite { get; set; }
    }
}
