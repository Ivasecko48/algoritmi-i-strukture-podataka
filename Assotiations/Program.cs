using System;

namespace MafiaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Mafia mafia = new Mafia("Corleone", "Construction");

            Boss boss = new Boss("Vito Corleone");

            mafia.SetBoss(boss);

            Console.WriteLine(mafia.ToString());

            Console.WriteLine(boss.ToString());
            
            boss.GiveOrder();
        }
    }
}
