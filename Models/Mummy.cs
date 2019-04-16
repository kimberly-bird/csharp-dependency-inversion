using System;
using System.Collections.Generic;

namespace monster_dependency_inversion
{
    public class Mummy : Slime, ICombustable
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine($"You just killed the Mummy with {attack}");
            }
        }
    }
}

