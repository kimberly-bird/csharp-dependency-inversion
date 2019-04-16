using System;
using System.Collections.Generic;

namespace monster_dependency_inversion
{
    public class Ghast : Slime, ICombustable, ISplashable
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine($"You just killed the Ghast with {attack}");
            }
        }

        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine($"You just doused the Ghast with {attack}");
            }        
        }
    }
}

