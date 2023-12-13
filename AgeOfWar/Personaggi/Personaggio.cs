using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfWar.Personaggi
{
    public abstract class Personaggio
    {
        public int PuntiVita { get; set; }

        public int PuntiForza { get; set; }

        public int Squadra {  get; set; }

        public int Velocita { get; set; }

        public string? PuntiDifesa { get; set; }

        

    }
}
