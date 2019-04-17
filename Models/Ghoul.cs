using System;
using System.Collections.Generic;

namespace monster_dependency_inversion
{
    public class Ghoul : Monster, IStabbable, ISplashable
    {
        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine($"You just doused the Ghoul with {attack}");
            }
        }

        public void Stab(string attack)
        {
            if (attack == "Silver Knife")
            {
                Console.WriteLine($"You just killed the Ghoul with {attack}");
            }
        }
    }
}

