using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciZadatak6
{
    class Avion : Vozilo
    {
        private int rasponKrila;
        private int maxVisina;

        public Avion(int idBroj, int tezina, int maxBrzina, int rasponKrila, int maxVisina) : base(idBroj, tezina, maxBrzina)
        {
            MaxVisina = maxVisina;
            RasponKrila = rasponKrila;
        }

        public int RasponKrila { get => rasponKrila; set => rasponKrila = value; }
        public int MaxVisina { get => maxVisina; set => maxVisina = value; }

        public override string ToString()
        {
            return "AVION => Id broj: " + IdBroj.ToString() + " Težina: " + Tezina.ToString() + " Max. brzina: " + MaxBrzina.ToString() + " Max. visina: " + MaxVisina.ToString() + " Raspon krila: " + RasponKrila.ToString();
        }
    }
}
