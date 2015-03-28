using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loto_aplikacija
{
    class Loto
    {
        public List<int> UplaceniBrojevi { get; set; }
        public List<int> DobitniBrojevi { get; set; }

        /// <summary>
        /// KOnstruktor klase.
        /// </summary>
 
        public Loto()
        {
            UplaceniBrojevi = new List<int>();
            DobitniBrojevi = new List<int>();
        }
        public bool unesiUplaceneBrojeve(List<string> korisnickeVrijednosti )
        {
            bool ispravni = false;
            UplaceniBrojevi.Clear();
            foreach (string b in korisnickeVrijednosti)
            {
                int broj=0;

                if (broj >= 1 && broj <= 39)
                {
                    if (UplaceniBrojevi.Contains(broj) == false)
                    {
                        UplaceniBrojevi.Add(broj);
                    }
                }
            }
            if (UplaceniBrojevi.Count == 7)
            {
                ispravni =  true;
            }
            return ispravni;
        }
        public void GenerirajDobitnuKombinaciju()
        {
            DobitniBrojevi.Clear();
            Random GeneratorBrojeva = new Random();
            while (DobitniBrojevi.Count < 7)
            {
                int broj = GeneratorBrojeva.Next(1, 39);
                if (DobitniBrojevi.Contains(broj) == false)
                {
                    DobitniBrojevi.Add(broj);
                }
            }
        }
        public int IzracunajBrojPogodaka()
        {
            int brojPogodaka = 0;
            foreach (int broj in UplaceniBrojevi)
            {
                if (DobitniBrojevi.Contains(broj) == true)
                {
                    brojPogodaka++;
                }
            }
            return brojPogodaka;
        }

    }
}
