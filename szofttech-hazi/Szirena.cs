using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace szofttech_hazi
{
    class Szirena : IRiasztasiKezelo
    {
        VezerloPanel VezerloPanel;
        bool[] allapotok;

        public Szirena(VezerloPanel vezerloPanel)
        {
            VezerloPanel = vezerloPanel;
            vezerloPanel.RiasztasiKezeloHozaadasa(this);
            allapotok = new bool[2];
        }

        public void Frissites()
        {
            allapotok = VezerloPanel.GetRiasztasiAllapot();
            Riasztas();
        }

        private void Riasztas()
        {
            if (allapotok[0] && allapotok[1])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 1);
                Console.Write("Né");
                Thread.Sleep(1000);
                Console.Clear();
                Console.SetCursorPosition(0, 1);
                Console.Write("Nó");
                Thread.Sleep(1000);
                Console.Clear();
            }
            else if (allapotok[0])
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(0, 1);
                Console.Write("Né");
                Thread.Sleep(1000);
                Console.Clear();
                Console.SetCursorPosition(0, 1);
                Console.Write("Nó");
                Thread.Sleep(1000);
                Console.Clear();
            }
            else if (allapotok[1])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 1);
                Console.Write("Né");
                Thread.Sleep(1000);
                Console.Clear();
                Console.SetCursorPosition(0, 1);
                Console.Write("Nó");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
