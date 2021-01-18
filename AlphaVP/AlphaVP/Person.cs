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

        public Person(Random rdm)
        {
            this.rdm = rdm;
        }

        public Person(Random rdm, PersonState state)
        {
            this.state = state;
            this.rdm = rdm;
        }

        public PersonState State { get => state; }

        public PersonState Action(float chancesOfInfection)
        {
            if (state != PersonState.Dead)
            {
                float tRdm = (float)rdm.Next(0, 100) + (float)rdm.NextDouble(); // ?
                if (tRdm <= chancesOfInfection)
                {
                    // Console.WriteLine(tRdm);
                    state = PersonState.Infected;
                }
            }
            return State;
        }
    }
}
