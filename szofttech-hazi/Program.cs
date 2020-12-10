﻿using System;
using System.Collections.Generic;
using System.Text;

namespace szofttech_hazi
{
    class Program
    {
        public static void Main(string[] args)
        {
            Riasztorendszer riasztorendszer = new Riasztorendszer();
            VezerloPanel vezerloPanel = new VezerloPanel();
            Fenyvillogo fenyvillogo = new Fenyvillogo(vezerloPanel);
            Szirena szirena = new Szirena(vezerloPanel);
            RendorsegiErtesitoAdapter rendorsegiErtesitoAdapter = new RendorsegiErtesitoAdapter(vezerloPanel);
            //vezerloPanel.setEgyszeruRiasztas();
            //vezerloPanel.setTuzjelzesiRiasztas();
            vezerloPanel.setMindketto();
        }
    }
}
