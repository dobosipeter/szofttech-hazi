using System;
using System.Collections.Generic;
using System.Text;

namespace szofttech_hazi
{
    class Riasztorendszer
    {
        protected static List<Esemeny> esemenyek = new List<Esemeny>();
        protected List<IRiasztasiKezelo> riasztasiKezelok;

        public void RiasztasiKezeloHozaaadasa(IRiasztasiKezelo riasztasiKezelo){}
        public void RiasztasiKezeloEltavolitasa(IRiasztasiKezelo riasztasiKezelo){}
        public void RiasztasiKezelokErtesitese()
        {
            foreach (var riasztasiKezelo in riasztasiKezelok)
            {
                riasztasiKezelo.Frissites();
            }
        }
    }
}
