using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_HK1B_Demo.BeeGame
{
    internal class Game
    {
        private List<Bee> bees = new List<Bee>();

        public Game()
        {
            for (int i = 0; i < 10; i++)
            {
                bees.Add(new Drone());
                bees.Add(new Worker());
                bees.Add(new Queen());
            }
        }

        public void AttackBees()
        {
            Random random = new Random();
            foreach (Bee bee in bees)
            {
                bee.Attack(random.Next(1, 10));
            }
        }

        public void PrintBees()
        {
            foreach (Bee bee in bees)
            {
                Console.WriteLine(bee);
            }
        }
    }
}
