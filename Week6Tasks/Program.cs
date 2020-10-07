using System;

namespace Week6Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] superHeroes = { "Batman", "Santa", "Spongebob", "Thor", "Harry Potter" };
            string[] superVillains = { "Godzilla", "Voldemort", "Grinch", "Darth Vader", "T-1000" };
            string[] weapon = { "banana", "fork", "keyboard", "purse", "jar of mud" };

            Random rnd = new Random();

            Console.WriteLine($"{superHeroes[rnd.Next(0, superHeroes.Length)]} will fight {superVillains[rnd.Next(0, superVillains.Length)]} with a {weapon[rnd.Next(0, weapon.Length)]}");

        }
    }
}
