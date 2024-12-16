using System;

namespace MafiaApp
{
    public class Mafia
    {
        private string name;
        private string business;
        private Boss boss;

        public Mafia(string name, string business)
        {
            this.name = name;
            this.business = business;
        }

        public void SetBoss(Boss boss)
        {
            this.boss = boss;
        }

        public void PerformSecretActivity()
        {
            Console.WriteLine($"{name} is performing a secret activity in the {business} business.");
        }

        public override string ToString()
        {
            return $"Mafia Name: {name}, Business: {business}, Boss: {boss?.ToString() ?? "No boss assigned"}";
        }
    }
}
