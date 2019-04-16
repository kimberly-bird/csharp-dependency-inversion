using System;
using System.Collections.Generic;

namespace monster_dependency_inversion
{
    public class Hunter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Weapons { get; } = new List<string>() {
        "Silver", "Fire", "Holy Water"
    };

        public Hunter(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public void SuperDuperKillerSlime(Slime slime)
        {
            slime.DefinitelyKills("Slime");
        }

        public void SplashWater(ISplashable splashable)
        {
            splashable.Douse("Holy Water");  // Kills with holy water
        }

        public void Ignite(ICombustable combustable)
        {
            combustable.Burn("Fire");  // Kills with fire
        }

        public void WieldSilver(IStabbable stabbable)
        {
            stabbable.Stab("Silver Knife");   // Stabs with silver knife
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} kills monsters with the following weapons: {String.Join(", ", Weapons)}";
        }
    }
}
