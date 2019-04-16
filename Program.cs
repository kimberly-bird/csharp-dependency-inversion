using System;

namespace monster_dependency_inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

            Mummy tuts = new Mummy();
            Demon demonbreun = new Demon();

            VonRimmersmark.Ignite(tuts);

            VonRimmersmark.SplashWater(demonbreun);

            VonRimmersmark.SuperDuperKillerSlime(tuts);
        }
    }
}
