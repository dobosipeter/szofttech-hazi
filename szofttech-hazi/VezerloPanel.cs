using System;
using System.Collections.Generic;
using System.Threading;

namespace szofttech_hazi
{
    class VezerloPanel : Riasztorendszer
    {
        private bool egyszeruRiasztas;
        private bool tuzJelzesRiasztas;
        public VezerloPanel()
        {
            riasztasiKezelok = new List<IRiasztasiKezelo>();
            egyszeruRiasztas = false;
            tuzJelzesRiasztas = false;
        }

        public bool[] GetRiasztasiAllapot()
        {
            bool[] allapot = {egyszeruRiasztas, tuzJelzesRiasztas};
            return allapot;
        }

        public void TimeStuff()
        {
            for (int i = 0; i < 5; i++)
            {
                RiasztasiKezelokErtesitese();
                Thread.Sleep(1000);
            }
        }

        public void setEgyszeruRiasztas()
        {
            egyszeruRiasztas = true;
            esemenyek.Add(new Esemeny(DateTime.Now, Esemeny.EsemenyTipusok.EGYSZERU));
            TimeStuff();
            egyszeruRiasztas = false;
            RiasztasiKezelokErtesitese();
        }

        public void setTuzjelzesiRiasztas()
        {
            tuzJelzesRiasztas = true;
            esemenyek.Add(new Esemeny(DateTime.Now, Esemeny.EsemenyTipusok.TUZ));

            tuzJelzesRiasztas = false;
            RiasztasiKezelokErtesitese();
        }

        public void setMindketto()
        {
            egyszeruRiasztas = true;
            esemenyek.Add(new Esemeny(DateTime.Now, Esemeny.EsemenyTipusok.EGYSZERU));
            tuzJelzesRiasztas = true;
            esemenyek.Add(new Esemeny(DateTime.Now, Esemeny.EsemenyTipusok.TUZ));

            egyszeruRiasztas = false;
            tuzJelzesRiasztas = false;
            RiasztasiKezelokErtesitese();
        }
    }
}
