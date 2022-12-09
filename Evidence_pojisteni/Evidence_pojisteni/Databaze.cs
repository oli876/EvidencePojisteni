using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojisteni
{
    /// <summary>
    /// Třída databáze záznamů
    /// </summary>
    internal class Databaze
    {
        /// <summary>
        /// Kolekce záznamů
        /// </summary>
        private List<Pojisteny> pojisteneOsoby;


        /// <summary>
        /// Nová instance databáze
        /// </summary>
        public Databaze()
        {
            pojisteneOsoby = new List<Pojisteny>();
        }

        /// <summary>
        /// Přidá nového pojištěného do databáze
        /// </summary>
        /// <param name="Jmeno">Jméno pojištěného</param>
        /// <param name="Prijmeni">Příjmení pojištěného</param>
        /// <param name="Vek">Věk pojištěného</param>
        /// <param name="Telefon">Telefon pojištěného</param>
        public void PridejPojisteny(string Jmeno, string Prijmeni, int Vek, int Telefon)
        {
            pojisteneOsoby.Add(new Pojisteny(Jmeno, Prijmeni, Vek, Telefon));
        }
    

        /// <summary>
        /// Najde záznam 
        /// </summary>
        /// <param name="Jmeno"></param>
        /// <param name="Prijmeni"></param>
        /// <returns></returns>
        public List<Pojisteny> NajdiPojisteny(string Jmeno, string Prijmeni)
        {
            List<Pojisteny> nalezene = new List<Pojisteny>();

            foreach(Pojisteny p in pojisteneOsoby)
            {
                if ((p.Jmeno == Jmeno) && (p.Prijmeni == Prijmeni))
                        nalezene.Add(p);
            }
            return nalezene;

        }

        /// <summary>
        /// Vypíše všechny pojištěné osoby v databázi.
        /// </summary>
        public void VypisPojisteny()
        {
            
            foreach (Pojisteny p in pojisteneOsoby)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.WriteLine();
            Console.ReadKey();

        }

    }
}
