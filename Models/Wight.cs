using System;

namespace monster_dependency_inversion
{
    public class Wight : Monster, IStabbable
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