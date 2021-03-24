using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion_practice
{

    //Spiderman is capable to jump one or two buildings
    //0				|	|	|	|
	//Spiderman b1  b2 b3  b4
    //Spider could jump to b1, or b2.Once Spiderman has jumped to the b2, he could jump to the b3 or b4 buildings.
    //Spiderman is always able to jump 1 or 2 buildings.
    //How many ways has Spiderman to go up n buildings.

    public class Spiderman
    {
       public int floors;
       public int Spider(int floors)
        {
          
            if (floors <= 1)
            {
                return floors;
            }
            return (Spider(floors - 1) + Spider(floors - 2));
        }

       public int way;
        public int Probableways(int way)
        {
            return Spider(way + 1);
        }
    }
}
