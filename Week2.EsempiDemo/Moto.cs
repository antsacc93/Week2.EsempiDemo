using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    class Moto : Veicolo
    {

        public int Cilindrata { get; set; }

        public override string ToString()
        {
            return $"Targa: {Targa} - Cilindrata: {Cilindrata} \n";
        }

    }
}
