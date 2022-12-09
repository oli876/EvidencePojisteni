using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojisteni
{
    /// <summary>
    /// Třída reprezentuje pojištěného, jeho jméno, příjmení, věk a telefon.
    /// </summary>
    internal class Pojisteny
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }
        public int Telefon { get; private set; }
        /// <summary>
        /// Konstruktor třídy pojištěný 
        /// </summary>
        /// <param name="Jmeno">jméno pojištěného</param>
        /// <param name="Prijmeni">příjmení pojištěného</param>
        /// <param name="Vek">věk pojištěného</param>
        /// <param name="Telefon">telefon pojištěného</param>
        public Pojisteny (string Jmeno, string Prijmeni, int Vek, int Telefon)
        {
            this.Jmeno = Jmeno;
            this.Prijmeni = Prijmeni;
            this.Vek = Vek;
            this.Telefon = Telefon;

        }
        /// <summary>
        /// Vrátí textovou reprezentaci pojištěného - jméno, příjmení, věk a telefon pojištěného
        /// </summary>
        /// <returns>jméno, příjmení, věk a telefon pojištěného</returns>
        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + " " + Vek + " " + Telefon;
        }
    }
}
