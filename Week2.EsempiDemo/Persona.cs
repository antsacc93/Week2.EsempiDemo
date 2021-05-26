using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    class Persona
    {
        //Campi
        //Proprietà
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cognome { get; set; } = "";

        private int _eta = 28; 
        public int Eta
        {
            get { return _eta; }
            set { _eta = value; }
        }

        private double _stipendio = 1000.00;
        public double Stipendio
        {
            get { return _stipendio; }
        }

        public double Stip { 
            get { 
                return CalcolaStipendio(); 
            } 
        }

        //se voglio modificare il valore dello stipendio dall'esterno allora lo
        //scrivo così:
        public double StipendioNonCalcolato { get; set; } = 1000.00;

        public DateTime DataNascita { get; set; } = new DateTime(1970, 1, 1);

        //Costruttore 
        public Persona() { }

        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        //Metodi
        internal virtual double CalcolaStipendio()
        {
            if (Cognome.StartsWith("1"))
            {
                throw new ArgumentException("Cognome non valido");
            }
            if(Eta >= 20 && Eta <= 25 || Cognome.StartsWith("S"))
            {
                _stipendio = _stipendio + (Stipendio * 10) / 100;
                //_stipendio += (_stipendio*10)/100;
            } else
            {
                _stipendio = _stipendio + (_stipendio * 20) / 100;
            }
            return _stipendio;
        }

        public virtual int GetNumber()
        {
            return 7;
        }

        public override string ToString()
        {
            //return "Nome: " + Nome + " Cognome: " + Cognome 
            return $"Nome: {Nome} Cognome: {Cognome} Età: {Eta} Data di Nascita: {DataNascita.ToShortDateString()}";
        }
    }
}
