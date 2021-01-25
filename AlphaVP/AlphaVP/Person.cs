using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVP
{
    class Person
    {
        PersonState state = PersonState.Healthy;
        Random rdm;
        Measure measureMask;

        public Person(Random rdm, Measure measureMask)
        {
            this.rdm = rdm;
            this.measureMask = measureMask;
        }

        public Person(Random rdm, Measure measureMask, PersonState state)
        {
            this.state = state;
            this.rdm = rdm;
            this.measureMask = measureMask;
        }

        public PersonState State { get => state; }

        /// <summary>
        /// Effectue une itération sur une personne. En effectuant un mouvement (Par exemple) et en calculant les chances qu'il a d'attraper le virus.
        /// </summary>
        /// <param name="chancesOfInfection">Chance d'être infecté par le virus pour cette itération</param>
        /// <returns>Retourne l'état de la personne</returns>
        public PersonState Action(float chancesOfInfection)
        {
            if (state == PersonState.Healthy)
            {
                float randomChances = (float)rdm.Next(0, 100) + (float)rdm.NextDouble(); // Probabilité d'attraper le virus.
                chancesOfInfection -= measureMask.Protection; // Chances d'être infecté par le virus.

                if (chancesOfInfection < 0)
                    chancesOfInfection = 0;

                if (randomChances <= chancesOfInfection)
                {
                    state = PersonState.Infected;
                }
            }
            return State;
        }
    }
}
