using System;
using System.Collections.Generic;
using System.Text;

namespace szofttech_hazi
{
    class Riasztorendszer
    {
        protected static List<Esemeny> esemenyek = new List<Esemeny>();
        protected List<IRiasztasiKezelo> riasztasiKezelok;

        public void RiasztasiKezeloHozaadasa(IRiasztasiKezelo riasztasiKezelo)
        {
            riasztasiKezelok.Add(riasztasiKezelo);
        }
        public void RiasztasiKezeloEltavolitasa(IRiasztasiKezelo riasztasiKezelo)
        {
            riasztasiKezelok.Remove(riasztasiKezelo);
        }
        public void RiasztasiKezelokErtesitese()
        {
            foreach (var riasztasiKezelo in riasztasiKezelok)
            {
                riasztasiKezelo.Frissites();
            }
        }
    }
}
