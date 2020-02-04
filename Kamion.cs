using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciZadatak6
{
    class Kamion : Vozilo
    {
        private int maxTezina;

        public int MaxTezina { get => maxTezina; set => maxTezina = value; }

        public Kamion(int idBroj, int tezina, int maxBrzina, int maxTezina) : base(idBroj, tezina, maxBrzina)
        {
            MaxTezina = maxTezina;
        }

        public override string ToString()
        {
            return "KAMION => Id broj: " + IdBroj.ToString() + " Težina: " + Tezina.ToString() + " Max. brzina: " + MaxBrzina.ToString() + " Max. težina tereta: " + MaxTezina.ToString();
        }
    }
}
