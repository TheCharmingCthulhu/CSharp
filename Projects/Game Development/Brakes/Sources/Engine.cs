using SFML.Graphics;
using System;

namespace Brakes.Resources
{
    class Engine
    {
        RenderWindow _Surface;

        public EventHandler Close { get; set; }

        public Engine(string title, uint width, uint height)
        {
            _Surface = new RenderWindow(new SFML.Window.VideoMode(width, height), title);
            _Surface.Closed += _Surface_Closed;

            Gameloop();
        }

        private void _Surface_Closed(object sender, EventArgs e)
        {
            if(_Surface.IsOpen) _Surface.Close();

            Close?.Invoke(sender, e);
        }

        private void Gameloop()
        {
            while (_Surface.IsOpen)
            {
                Update();
                Render();
            }
        }

        private void Update()
        {
            _Surface.DispatchEvents();
        }

        private void Render()
        {
            _Surface.Display();
        }
    }
}
