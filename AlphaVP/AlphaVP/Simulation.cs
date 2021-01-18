using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVP
{
    public enum PersonState
    {
        Healthy,
        Infected,
        HealthyCarrier,
        Dead
    }

    class Simulation
    {
        List<Person> persons = new List<Person>();
        Location location = new Location();
        Random rdm = new Random();
        public Simulation(int nbPersons)
        {
            for (int i = 0; i < nbPersons; i++)
            {
                Person person;
                if (i == 0) 
                    person = new Person(rdm, PersonState.Infected);
                else 
                    person = new Person(rdm);

                persons.Add(person);
                location.AddPerson(person);
            }
        }

        public void Action()
        {
            location.Action();
        }

        public int CalculateNbPersons()
        {
            return persons.Count();
        }

        public int CalculateNbInfected()
        {
            return location.GetNumberInfected();
        }
    }
}
