using WorldStamper.Sources.Interfaces;
using WorldStamper.Sources.Models.Editor.Modules;

namespace WorldStamper.Sources.Models.Editor.Configs
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
