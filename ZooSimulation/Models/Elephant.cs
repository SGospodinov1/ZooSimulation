using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSimulation.Models
{
    public class Elephant : Animal
    {
        public Elephant() : base()
        {
            CantWalk = false;
        }
        public bool CantWalk { get; set; }

        public override void Starvation()
        {
            if (Health >= 70)
            {
                CantWalk = false;
            }

            base.Starvation();

            if (Health < 70)
            {
                CantWalk = true;
            }
           
        }

        public override void CheckForDeath()
        {

            if (CantWalk && Health < 70)
            {
                IsAlive = false;
            }

        }
    }
}
