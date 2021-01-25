using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVP
{
    class Simulation
    {
        List<Person> persons;
        List<Location> locations;
        Virus virus;
        Location location;
        Random rdm = new Random();
        Measure measureMask;
        public Simulation(int nbPersons, int nbLocations)
        {
            measureMask = new Measure(0);

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

        /// <summary>
        /// Effectue les actions de tous les lieux existants.
        /// </summary>
        public void Action()
        {
            locations.AsParallel().ForAll(x => x.Action());
        }

        /// <summary>
        /// Calcul le nombre de personne total de la simulation.
        /// </summary>
        /// <returns>Nombre de personnes</returns>
        public int CalculateNbPersons()
        {
            return persons.Count();
        }

        /// <summary>
        /// Calcul le nombre d'infecté total.
        /// </summary>
        /// <returns>Nombre d'infecté</returns>
        public int CalculateNbInfected()
        {
            return locations.Sum(x => x.GetNumberInfected());
        }

        /// <summary>
        /// Retourne une liste de toutes les personnes infectées.
        /// </summary>
        /// <returns>List des personnes infectées</returns>
        public List<int> GetInfected()
        {
            return locations.Select(x => x.GetNumberInfected()).ToList();
        }

        /// <summary>
        /// Retourne une liste de toutes les personnes saines.
        /// </summary>
        /// <returns>List des personnes saines</returns>
        public List<int> GetHealthy()
        {
            return locations.Select(x => x.GetNumberhealthy()).ToList();
        }

        public List<Person> GetPersons()
        {
            return persons; // Clone
        }

        /// <summary>
        /// Crée des batiments et des zones.
        /// </summary>
        /// <param name="nbPersons">Nombre de personnes à créer</param>
        /// <param name="pLocation">Emplacements du type batîment</param>
        private void CreateLocation(int nbPersons, Location pLocation)
        {
            for (int i = 0; i < nbPersons; i++)
            {
                Person person;
                if (i == 0)
                    person = new Person(rdm, measureMask, PersonState.Infected);
                else
                    person = new Person(rdm, measureMask);

                persons.Add(person);
                pLocation.AddPerson(person);
            }
        }
    }
}
