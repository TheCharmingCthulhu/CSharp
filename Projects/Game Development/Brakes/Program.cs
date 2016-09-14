using Brakes.Resources;

namespace Brakes.Sources
{
    public class Program
    {
        static Engine _brakes;

        public static void Main(string[] args)
        {
            _brakes = new Engine("Brakes", 640, 480);
        }
    }
}
