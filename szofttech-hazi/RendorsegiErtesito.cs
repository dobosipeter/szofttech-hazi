using System;
using System.Collections.Generic;
using System.Text;

namespace szofttech_hazi
{
    class RendorsegiErtesito
    {
        public void Beriaszt()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 0);
            Console.Write("Rendőrségi riasztás aktív!");
        }
        public void Kiriaszt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 0);
            Console.Write("Rendőrségi riasztás inaktív.  ");
        }
    }
}
