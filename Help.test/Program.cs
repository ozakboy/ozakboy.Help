using ozakboy.Help;

namespace Help.test
{
    internal class Program
    {
        public class Bas
        {
            public string Ob { get; set; }
            public string inoo { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var a = new Bas
            {
                inoo = "ad",
                Ob = "oof"
            };
            var b = a.ToJsonString();
        }
    }
}