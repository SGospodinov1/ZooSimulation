using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSimulation.Models
{
    public class Animal
    {
        public Animal()
        {
            Health = 100;
            IsAlive = true;
            DeathCondition = 0;
        }

        public int Health { get; set; }

        public int DeathCondition { get; set; }

        public bool IsAlive { get; set; }


        public virtual void Starvation()
        {
            Random random = new Random();

            int hp = random.Next(0, 21);

            Health -= hp;

            CheckForDeath();

        }

        public void Feeding()
        {
            Random random = new Random();

            int hp = random.Next(5, 26);

            Health += hp;

            if (Health > 100)
            {
                Health = 100;
            }
        }

        public virtual void CheckForDeath()
        {
            if (Health <= DeathCondition)
            {
                IsAlive = false;
            }
        }
    }

}
