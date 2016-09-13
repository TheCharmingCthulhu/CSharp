namespace WorldStamper.Sources.Models.MapModules
{
    class Transition
    {
        public class TransitionTarget
        {
            public int ID { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
        }

        public int X { get; set; }
        public int Y { get; set; }
        public TransitionTarget Target { get; set; }
    }
}
