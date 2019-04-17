using System;
using System.Collections.Generic;

namespace monster_dependency_inversion
{
    public class Mummy : Monster, ICombustable
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

