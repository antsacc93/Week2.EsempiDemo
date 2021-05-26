using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    class Impiegato : Persona
    {

        public String Mansione { get; set; }

        internal override double CalcolaStipendio()
        {
            if(Mansione == "Amministratore")
            {
                return base.CalcolaStipendio() + 2000;
            } else
            {
                return 1500;
            }
        }

    }
}
