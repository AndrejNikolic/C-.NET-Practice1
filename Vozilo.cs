using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciZadatak6
{
    abstract class Vozilo
    {
        private int idBroj;
        private int tezina;
        private int maxBrzina;

        protected int IdBroj { get => idBroj; set => idBroj = value; }
        protected int Tezina { get => tezina; set => tezina = value; }
        protected int MaxBrzina { get => maxBrzina; set => maxBrzina = value; }
        protected Vozilo(int idBroj, int tezina, int maxBrzina)
        {
            IdBroj = idBroj;
            Tezina = tezina;
            MaxBrzina = maxBrzina;
        }
    }
}
