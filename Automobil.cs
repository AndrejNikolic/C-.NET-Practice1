using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciZadatak6
{
    class Automobil : Vozilo
    {
        private int brPutnika;

        public int BrPutnika { get => brPutnika; set => brPutnika = value; }

        public Automobil(int idBroj, int tezina, int maxBrzina, int brPutnika) : base(idBroj, tezina, maxBrzina)
        {
            BrPutnika = brPutnika;
        }

        public override string ToString()
        {
            return "AUTOMOBIL => Id broj: " + IdBroj.ToString() + " Težina: " + Tezina.ToString() + " Max. brzina: " + MaxBrzina.ToString() + " Broj putnika: " + BrPutnika.ToString();
        }

    }
}
