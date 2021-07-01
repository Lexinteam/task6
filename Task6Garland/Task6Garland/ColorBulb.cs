using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6Garland
{
    class ColorBulb
    {
        public int Number { get; set; }
        public bool OnOff { get; set; }

        public BulbColor Color { get; set; }


        public enum BulbColor 
        {
            Red = 1,
            Yellow = 2,
            Blue = 3,
            Green = 4   
        }


    }
}
