using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojisteni
{       

    /// <summary>
    /// Třída reprezentuje evidenci pojištění
    /// </summary>
    internal class Evidence
    {
        /// <summary>
        /// Databáze se záznamy
        /// </summary>
        public Databaze databaze { get; private set; }

        /// <summary>
        /// Nová instance evidence
        /// </summary>
        public Evidence()
        {
            databaze = new Databaze();
        }

        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }
        public int Telefon { get; private set; }
        
        /// <summary>
        /// Zadání údajů pojištěného.
        /// </summary>
        public void PridejPojisteny()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            Jmeno = Console.ReadLine().ToUpper().Trim();
            Console.WriteLine();

            Console.WriteLine("Zadejte příjmení:");
            Prijmeni = Console.ReadLine().ToUpper().Trim();
            Console.WriteLine();

            Console.WriteLine("Zadejte věk:");
            Vek = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Zadejte telefonní číslo:");
            Telefon = int.Parse(Console.ReadLine());
            Console.WriteLine();

            databaze.PridejPojisteny(Jmeno, Prijmeni, Vek, Telefon);
            Console.WriteLine();
            Console.WriteLine("Data byla uložena. Pokraujte libovolnou klávesou...");
            Console.WriteLine();
            Console.ReadKey();
        }

        
        /// <summary>
        /// Vyhledá pojištěného v databázi pojištěných
        /// </summary>
        /// <param name="Jmeno"></param>
        /// <param name="Prijmeni"></param>
        public void VyhledejPojisteny()
        {
            // Uživatel zadá jméno
            Console.WriteLine("Zadejte jméno pojištěného:");
            Jmeno = Console.ReadLine().ToUpper().Trim();
            Console.WriteLine();

            // Uživatel zadá příjmení
            Console.WriteLine("Zadejte příjmení pojištěného:");
            Prijmeni = Console.ReadLine().ToUpper().Trim();
            Console.WriteLine();



            //Vyhledání záznamu
            List<Pojisteny> pojisteneOsoby = databaze.NajdiPojisteny(Jmeno, Prijmeni);
            if (pojisteneOsoby.Count() > 0)
            {
                foreach (Pojisteny p in pojisteneOsoby)
                {
                    Console.WriteLine(p);
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");
                Console.WriteLine();
                Console.ReadKey();
            }

            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.ReadKey();
            
        }
        
        /// <summary>
        /// Vypíše hlavičku do konzole
        /// </summary>
        public void VypisHlavicku()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Evidence pojistenych");
            Console.WriteLine("------------------------------");
        }
    }
}
