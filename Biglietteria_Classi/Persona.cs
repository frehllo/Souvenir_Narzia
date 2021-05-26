using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biglietteria_Classi
{
    public class Persona
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }

        public Persona(string n, string c)
        {
            Nome = n;
            Cognome = c;
        }
    }
}
