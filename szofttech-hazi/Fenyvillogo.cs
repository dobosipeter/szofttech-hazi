using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace szofttech_hazi
{
    class Fenyvillogo : IRiasztasiKezelo
    {
        VezerloPanel vezerloPanel;
        private bool egyszeruRiasztas;
        private bool tuzJelzesRiasztas;
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

        public void Riasztas()
        {
            if (allapotok[0] && allapotok[1])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 0);
                Console.Write("Riasztás!");
                Console.SetCursorPosition(10, 0);
                Console.Write("Tűzjelző!");
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);
            }
            else if (allapotok[0])
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(0, 0);
                Console.Write("Riasztás!");
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);
            }
            else if (allapotok[1])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(10, 0);
                Console.Write("Tűzjelző!");
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);
            }
        }
    }
}
