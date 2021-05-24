using System;
using System.Diagnostics;

namespace Week2.EsempiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Iterazione VS Ricorsione
            //Esercizi.FibonacciIterativo(5);
            //Esercizi.FibonacciRicorsivo(5);

            Stopwatch watch = new Stopwatch();
            watch.Start();
            //richiamo fibonacci iterativo
            for(int i = 0; i < 100; i++)
            {
                //Console.WriteLine(Esercizi.FibonacciIterativo(i));
            }
            watch.Stop();
            Console.WriteLine("Il metodo iterativo ha impiegato {0}", watch.ElapsedMilliseconds);

            Console.WriteLine();
            Stopwatch watch2 = new Stopwatch();
            //watch2.Reset();
            
            
            watch2.Start();
            //richiamo fibonacci ricorsivo
            for(int i = 0; i < 100; i++)
            {
                //Console.WriteLine(Esercizi.FibonacciRicorsivo(i));
            }
            watch2.Stop();
            Console.WriteLine("Il metodo ricorsivo ha impiegato {0}", watch2.ElapsedMilliseconds);
            #endregion

            Persona persona = new Persona();
            persona.Nome = "Antonia";
            persona.Cognome = "Sacchitella";
            persona.Eta = 28;
            //richiamo il metodo calcola stipendio
            //persona.CalcolaStipendio();
            Console.WriteLine("Il mio nome è: {0}", persona.Nome);
            Console.WriteLine("Il mio cognome è: {0}", persona.Cognome);
            Console.WriteLine("La mia eta è: {0}", persona.Eta);
            Console.WriteLine("Il mio stipendio è {0} euro", persona.Stipendio);
            Console.WriteLine("La mia data di nascita è {0}", persona.DataNascita);

            Persona persona2 = new Persona();
            persona2.Nome = "Mario";
            Console.WriteLine("Il mio nome è {0}", persona2.Nome);
            Console.WriteLine("La mia età è {0}", persona2.Eta);

            Persona persona3 = new Persona()
            {
                Nome = "Luigi",
                Cognome = "Verdi",
                Eta = 18,
                DataNascita = new DateTime(2000, 12, 6),
                StipendioNonCalcolato = 2000
            };

            Persona persona4 = new Persona("Giordano", "Bruno", 45);
            Console.WriteLine("Nome: {0} - Cognome: {1} - Età: {2} Data di Nascita: {3}",
                persona4.Nome, persona4.Cognome, persona4.Eta, persona4.DataNascita);
            Console.WriteLine("Persone inserite");
            Console.WriteLine(persona.ToString());
            Console.WriteLine(persona2.ToString());
            Console.WriteLine(persona3.ToString());
            Console.WriteLine(persona4.ToString());

        }
    }
}
