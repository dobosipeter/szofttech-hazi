using System;
using System.Collections.Generic;
using System.Text;

namespace szofttech_hazi
{
    class RendorsegiErtesitoAdapter : IRiasztasiKezelo
    {
        RendorsegiErtesito RendorsegiErtesito { get; set; }
        VezerloPanel vezerloPanel;
        bool[] allapotok;

        public RendorsegiErtesitoAdapter(VezerloPanel vezerloPanel)
        {
            RendorsegiErtesito = new RendorsegiErtesito();
            this.vezerloPanel = vezerloPanel;
            vezerloPanel.RiasztasiKezeloHozaadasa(this);
            allapotok = new bool[2];
        }

        public void Frissites()
        {
            allapotok = vezerloPanel.GetRiasztasiAllapot();
            Riasztas();
        }

        private void Riasztas()
        {
            if (allapotok[0])
            {
                RendorsegiErtesito.Beriaszt();
            }
            else
            {
                RendorsegiErtesito.Kiriaszt();
            }
        }
    }
}
