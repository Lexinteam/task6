using System;

namespace Task6Garland
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic implementation
            Console.WriteLine("Hello World!");
            BWGarland g1 = new BWGarland();
            g1.ShowBulbState();


            ColorGarland g2 = new ColorGarland();
            g2.ShowBulbState();

        }

    }
}
