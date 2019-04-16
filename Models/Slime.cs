using System;
using System.Collections.Generic;

namespace monster_dependency_inversion
{
    public class Slime
    {
        public void DefinitelyKills(string attack)
        {
            if (attack == "Slime")
            {
                Console.WriteLine("You just killed the thing with SLIME!");
            }
        }
    }
}

