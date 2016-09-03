using System.Collections.Generic;
using WorldStamper.Sources.Models;

namespace WorldStamper.Sources.Views
{
    class Tool
    {
        public enum ToolMode
        {
            Cursor,
            Paint,
            Entity
        }

        public ToolMode Mode { get; set; } = ToolMode.Cursor;
        public Sprite Sprite { get; set; }
    }
}
