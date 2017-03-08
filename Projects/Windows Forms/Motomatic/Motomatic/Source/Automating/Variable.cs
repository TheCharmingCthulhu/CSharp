namespace Motomatic.Source.Automating
{
    public class Variable
    {
        public string Name { get; set; }
        public string Value { get; set; }

        private Variable(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public static Variable Create(string name, int value)
        {
            return Create(name, value.ToString());
        }

        public static Variable Create(string name, bool value)
        {
            return Create(name, value.ToString());
        }

        public static Variable Create(string name, float value)
        {
            return Create(name, value.ToString());
        }

        public static Variable Create(string name, double value)
        {
            return Create(name, value.ToString());
        }

        public static Variable Create(string name, string value)
        {
            return new Variable(name, value.ToString());
        }
    }
}
