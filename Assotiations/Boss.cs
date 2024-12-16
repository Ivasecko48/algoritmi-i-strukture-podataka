using System;

namespace MafiaApp
{
    public class Boss
    {
        private string name;
        private Mafia mafia;

        public Boss(string name)
        {
            this.name = name;
        }

        public void SetMafia(Mafia mafia)
        {
            this.mafia = mafia;
        }
        public void GiveOrder()
        {
            if (mafia != null)
            {
                Console.WriteLine($"{name} is giving an order to the mafia.");
                mafia.PerformSecretActivity();
            }
            else
            {
                Console.WriteLine($"{name} has no mafia to give orders to.");
            }
        }

        public override string ToString()
        {
            return $"Boss Name: {name}, Mafia: {mafia?.ToString() ?? "No mafia linked"}";
        }
    }
}
