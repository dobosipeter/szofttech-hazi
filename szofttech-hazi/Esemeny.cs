using System;
using System.Collections.Generic;
using System.Text;

namespace szofttech_hazi
{
    class Esemeny
    {
        public enum EsemenyTipusok
        {
            EGYSZERU,
            TUZ
        };

        public DateTime DateTime { get; set; }
        public EsemenyTipusok EsemenyTipus { get; set; }

        public Esemeny(DateTime dateTime, EsemenyTipusok esemenyTipus)
        {
            DateTime = dateTime;
            EsemenyTipus = esemenyTipus;
        }
    }
}
