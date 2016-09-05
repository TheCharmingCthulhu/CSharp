namespace WorldStamper.Sources.Models.Editor
{
    class MapConfig
    {
        public Tool Tool { get; set; } = new Tool();
        public Tileset SelectedTileset { get; set; }
        public Image SelectedImage { get; set; }

        internal void ClearSelection()
        {
            SelectedImage = null;
            SelectedTileset = null;
        }
    }
}
