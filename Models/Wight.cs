using System;

namespace monster_dependency_inversion
{
    public class Wight : Slime, IStabbable
    {
        public void Stab(string attack)
        {
            if (attack == "Silver Knife")
            {
                Console.WriteLine($"You just killed the Wight with {attack}");
            }
        }
    }
}