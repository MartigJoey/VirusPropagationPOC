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
        List<Person> persons;
        List<Location> locations;
        Virus virus;
        Location location;
        Random rdm = new Random();
        public Simulation(int nbPersons)
        {
            int nbLocations = 5;

            persons = new List<Person>();
            locations = new List<Location>();
            virus = new Virus();

            for (int i = 0; i < nbLocations; i++)
            {
                location = new Location(virus);
                CreateLocation(nbPersons / nbLocations, location);
                locations.Add(location);
            }
            
        }


        public void Action()
        {
            locations.AsParallel().ForAll(x => x.Action());
        }

        public int CalculateNbPersons()
        {
            return persons.Count();
        }

        public int CalculateNbInfected()
        {
            return locations.Sum(x => x.GetNumberInfected());
        }

        public List<int> GetNbInfectedByLocation()
        {
            return locations.Select(x => x.GetNumberInfected()).ToList();
        }

        private void CreateLocation(int nbPersons, Location pLocation)
        {
            for (int i = 0; i < nbPersons; i++)
            {
                Person person;
                if (i == 0)
                    person = new Person(rdm, PersonState.Infected);
                else
                    person = new Person(rdm);

                persons.Add(person);
                pLocation.AddPerson(person);
            }
        }
    }
}
