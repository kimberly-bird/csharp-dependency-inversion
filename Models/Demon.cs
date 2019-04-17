using System;
using System.Collections.Generic;

namespace monster_dependency_inversion
{
    public class Demon : Monster, ICombustable, ISplashable, IStabbable
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine($"You just killed the Demon with {attack}");
            }
        }

        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine($"You just doused the Demon with {attack}");
            }
        }

        public void Stab(string attack)
        {
            if (attack == "Silver Knife")
            {
                Console.WriteLine($"You just killed the Demon with {attack}");
            }
        }
    }
}

