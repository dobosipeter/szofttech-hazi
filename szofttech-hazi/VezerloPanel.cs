using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace szofttech_hazi
{
    class VezerloPanel : Riasztorendszer
    {
        private bool egyszeruRiasztas;
        private bool tuzJelzesRiasztas;
        private static Timer oneSecTimer;
        private static Timer fiveSecTimer;
        public VezerloPanel()
        {
            riasztasiKezelok = new List<IRiasztasiKezelo>();
            egyszeruRiasztas = false;
            tuzJelzesRiasztas = false;
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
            TimeStuff();
            tuzJelzesRiasztas = false;
            RiasztasiKezelokErtesitese();
        }

        public void setMindketto()
        {
            egyszeruRiasztas = true;
            esemenyek.Add(new Esemeny(DateTime.Now, Esemeny.EsemenyTipusok.EGYSZERU));
            tuzJelzesRiasztas = true;
            esemenyek.Add(new Esemeny(DateTime.Now, Esemeny.EsemenyTipusok.TUZ));
            TimeStuff();
            egyszeruRiasztas = false;
            tuzJelzesRiasztas = false;
            RiasztasiKezelokErtesitese();
        }

        private void TimeStuff()
        {
            SetOneSecTimer();
            SetFiveSecTimer();
        }

        private void SetOneSecTimer()
        {
            oneSecTimer = new Timer(1000);
            oneSecTimer.Elapsed += oneSecPassedEventHandler;
            oneSecTimer.AutoReset = true;
            oneSecTimer.Enabled = true;
        }

        private void oneSecPassedEventHandler(object sender, ElapsedEventArgs e)
        {
            RiasztasiKezelokErtesitese();
        }

        private void SetFiveSecTimer()
        {
            fiveSecTimer = new Timer(5000);
            fiveSecTimer.Elapsed += fiveSecPassedEventHandler;
            fiveSecTimer.Enabled = true;
        }

        private void fiveSecPassedEventHandler(object sender, ElapsedEventArgs e)
        {
            oneSecTimer.Enabled = false;
        }
    }
}
