using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVP
{
    class Location
    {
        List<Person> persons;
        Virus virus;
        float chancesOfInfection = 0;

        public float ChancesOfInfection { get => chancesOfInfection; set => chancesOfInfection = value; }

        public Location(Virus virus)
        {
            persons = new List<Person>();
            this.virus = virus;
        }

        /// <summary>
        /// Calcul les chances d'infections puis tente de propager le virus.
        /// </summary>
        public void Action()
        {
            ChancesOfInfection = (float)GetNumberInfected() * virus.Propagation; // À modifié pour quelque chose de plus précis

            Parallel.For(0, persons.Count, i => {
                if (persons[i].State != PersonState.Infected && persons[i].State != PersonState.HealthyCarrier)
                {
                    persons[i].Action(ChancesOfInfection);
                }
            });
        }

        /// <summary>
        /// Calcul le nombre de personnes infectées.
        /// </summary>
        /// <returns>Nombre de personnes infectées</returns>
        public int GetNumberInfected()
        {
            return persons.Where(x => x.State == PersonState.Infected || x.State == PersonState.HealthyCarrier).Count();
        }

        /// <summary>
        /// Calcul le nombre de personnes saines.
        /// </summary>
        /// <returns>Nombre de personnes saines</returns>
        public int GetNumberhealthy()
        {
            return persons.Where(x => x.State == PersonState.Healthy).Count();
        }

        /// <summary>
        /// Ajoute une personne à la liste de personne.
        /// </summary>
        /// <param name="person">Personne à ajouter à la liste</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        /// <summary>
        /// Retire une personne de la liste de personnes.
        /// </summary>
        /// <param name="person">La personne à retirer</param>
        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }
    }
}
