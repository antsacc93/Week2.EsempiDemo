using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    class Studente : Persona
    {
        public String Matricola { get; set; }

        internal override double CalcolaStipendio()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return base.ToString() + $"Matricola: {Matricola}";
        }

        public override int GetNumber()
        {
            return base.GetNumber() + (10 * 123343);
        }
    }
}
