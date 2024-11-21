using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_HK1B_Demo.BeeGame
{
    internal class Bee
    {
        public int Health { get; set; }
        public bool IsDead => Health <= 0;

        public Bee()
        {
            Health = 100;
        }

        public void Attack(int health)
        {
            if (!IsDead)
            {
                Health -= health;
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name} - Health: {Health}, Dead: {IsDead}";
        }
    }
}
