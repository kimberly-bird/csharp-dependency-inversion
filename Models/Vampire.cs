using System;

namespace monster_dependency_inversion
{
    public class Vampire : Slime, IStabbable, ICombustable
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine($"You just killed the Vampire with {attack}");
            }
        }

        void IStabbable.Stab(string attack)
        {
            if (attack == "Silver Knife")
            {
                Console.WriteLine($"You just killed the Vampire with {attack}");
            }
        }
    }
}