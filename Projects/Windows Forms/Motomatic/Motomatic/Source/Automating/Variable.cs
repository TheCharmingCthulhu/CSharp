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

        public static Variable Create(string name, dynamic value)
        {
            return Create(name, value.ToString());
        }
    }
}
