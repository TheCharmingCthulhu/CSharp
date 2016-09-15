using WorldStamper.Sources.Interfaces;

namespace WorldStamper.Sources.Models.Editor
{
    class MapConfig : IConfig
    {
        public Tool Tool { get; set; } = new Tool();
        public Tileset SelectedTileset { get; set; }
        public Image SelectedImage { get; set; }

        public void Clear()
        {
            SelectedImage = null;
            SelectedTileset = null;
        }
    }
}
