using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6Garland
{
    class ColorGarland : Garland
    {
        public List<ColorBulb> Garland = new List<ColorBulb>();

        // to add console.read
        public ColorGarland(int counter = 4)
        {

            while (counter != 0)
            {
                // TODO different colors using counter
                Garland.Add(new ColorBulb { Number = counter, OnOff = false, Color = ColorBulb.BulbColor.Red });

                counter--;
            }

        }
        public override void ShowBulbState()
        {
            // change state
            DateTime now = DateTime.Now;
            int m = now.Minute;
            if (m % 2 == 0 || m == 0)
            {
                foreach (ColorBulb b in Garland)
                {
                    b.OnOff = b.Number % 2 == 0 ? true : false;
                }
            }
            else if (m % 2 != 0 || m != 1)
            {
                foreach (ColorBulb b in Garland)
                {
                    b.OnOff = b.Number % 2 != 0 ? true : false;
                }
            }

            Console.WriteLine("Color Garland:");

            // show state for each bulb
            foreach (ColorBulb b in Garland)
            {
                Console.WriteLine(b.Number + " State: " + b.OnOff + " Color: " + b.Color);
                // + color for ColorGarland
            }


        }
    }
}
