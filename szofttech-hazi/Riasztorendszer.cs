using System;
using System.Collections.Generic;
using System.Text;

namespace szofttech_hazi
{
    class Riasztorendszer
    {
        static List<Esemeny> esemenyek = new List<Esemeny>();
        List<IRiasztasiKezelo> riasztasiKezelok;

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
