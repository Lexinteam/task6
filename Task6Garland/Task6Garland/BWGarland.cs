using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6Garland
{
    public class BWGarland : Garland
    {
        public List<Bulb> Garland = new List<Bulb>();

        // to add console.read
        public BWGarland(int counter = 4) {

            while (counter != 0) {
                Garland.Add(new Bulb { Number = counter, OnOff = false }); 

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
                foreach (Bulb b in Garland) 
                {
                   b.OnOff =  b.Number % 2 == 0 ? true : false;
                 }
            } 
            else if (m % 2 != 0 || m != 1)
                {
                    foreach (Bulb b in Garland)
                    {
                        b.OnOff = b.Number % 2 != 0 ? true : false;
                    }
                }

            Console.WriteLine("Simple Garland:");

            // show state for each bulb
            foreach (Bulb b in Garland) {    
                Console.WriteLine(b.Number + " State: " + b.OnOff);
                // + color for ColorGarland
            }

                
        }
    }
}
