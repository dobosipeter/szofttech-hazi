using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace szofttech_hazi
{
    class Fenyvillogo : IRiasztasiKezelo
    {
        VezerloPanel vezerloPanel;
        bool[] allapotok;

        public Fenyvillogo(VezerloPanel vezerloPanel)
        {
            this.vezerloPanel = vezerloPanel;
            vezerloPanel.RiasztasiKezeloHozaadasa(this);
            allapotok = new bool[2];
        }

        public void Frissites()
        {
            allapotok = vezerloPanel.GetRiasztasiAllapot();
            Riasztas();
        }

        public void writeStuff(string szo, int eltolas)
        {
            Console.SetCursorPosition(eltolas, 3);
            Console.Write(szo);
        }

        public void timingStuff()
        {
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(1000);
        }

        public void Riasztas()
        {
            if (allapotok[0] && allapotok[1])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                writeStuff("Riasztás!", 0);
                writeStuff("Tűzjelző!", 10);
                timingStuff();
            }
            else if (allapotok[0])
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                writeStuff("Riasztás!", 0);
                timingStuff();
            }
            else if (allapotok[1])
            {
                writeStuff("Tűzjelző!", 10);
                timingStuff();
            }
        }
    }
}
