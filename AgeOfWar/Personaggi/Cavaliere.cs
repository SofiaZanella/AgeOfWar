using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfWar.Personaggi
{
    public class Cavaliere:Personaggio
    {
        public Cavaliere(int PuntiForza) //ctor
        {
            PuntiVita = 3000;
            PuntiForza += PuntiForza;
       
            
        }
    }
}
