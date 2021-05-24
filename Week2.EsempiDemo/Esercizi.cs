using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    class Esercizi
    {

        #region Iterazione VS Ricorsione
        // 0... 1... 1... 2... 3... 5... 8... 13
        public static int FibonacciIterativo(int n)
        {
            int primoNumero = 0;
            int secondoNumero = 1;
            int result = 0;

            if(n == 0)
            {
                return primoNumero;
            }
            if(n == 1)
            {
                return secondoNumero;
            }
            for(int i = 2; i <= n; i++)
            {
                result = primoNumero + secondoNumero;
                primoNumero = secondoNumero;
                secondoNumero = result;
            }

            return result;
        }

        public static int FibonacciRicorsivo(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            if(n == 1)
            {
                return 1;
            }
            return FibonacciRicorsivo(n - 1) + FibonacciRicorsivo(n - 2);
        }


        #endregion

    }
}
