using System;
using System.Collections.Generic;

namespace monster_dependency_inversion
{
    public class Monster
    {
        public void DefinitelyKills(string attack)
        {
            if (attack == "Slime")
            {
                Console.WriteLine("You just killed the thing with Slime!");
            }
        }
    }
}

