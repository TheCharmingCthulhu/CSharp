using System;

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

        public override bool Equals(object obj)
        {
            if (obj is Transition)
            {
                var transition = obj as Transition;

                return transition.X == X &&
                        transition.Y == Y &&
                        transition.Target.X == Target.X &&
                        transition.Target.Y == Target.Y &&
                        transition.Target.ID == Target.ID;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
