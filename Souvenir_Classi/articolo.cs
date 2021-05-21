using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Souvenir_Classi
{
    public class Articolo
    {
        public string Name { get; set; }
        public double Costo { get; set; }

        public Articolo(string n, double c)
        {
            Name = n;
            Costo = c;
        }
    }
}
