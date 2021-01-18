using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVP
{
    class Location
    {
        List<Person> persons = new List<Person>();
        Virus virus = new Virus();
        float chancesOfInfection = 0;

        public float ChancesOfInfection { get => chancesOfInfection; set => chancesOfInfection = value; }

        public Location(Virus virus)
        {
            this.virus = virus;
        }

        public void Action()
        {
            ChancesOfInfection = (float)GetNumberInfected() * virus.Propagation; // Super temporaire à coupler avec le virus

            // Console.WriteLine("Virus: " + ChancesOfInfection);
            Parallel.For(0, persons.Count, i => {
                if (persons[i].State != PersonState.Infected && persons[i].State != PersonState.HealthyCarrier)
                {
                    persons[i].Action(ChancesOfInfection);
                }
            });
        }

        public int GetNumberInfected()
        {
            return persons.Where(x => x.State == PersonState.Infected || x.State == PersonState.HealthyCarrier).Count();
        }

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }
    }
}
