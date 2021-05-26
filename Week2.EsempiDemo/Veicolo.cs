using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    class Veicolo
    {
        public String Targa { get; set; }
        public int NumeroRuote { get; set; }
        public int Telaio { get; set; }

        public override string ToString()
        {
            return $"Targa: {Targa} - Numero ruote {NumeroRuote} - Telaio: {Telaio} \n";
        }

    }
}
