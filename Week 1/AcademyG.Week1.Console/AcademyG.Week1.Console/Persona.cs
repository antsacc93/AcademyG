using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.Console
{
    public class Persona
    {
        //PROPRIETA'
        public string Nome { get; set; } = "Luca";
        //string Nome {get; set;} = "Luca"; -> PROPRIETA' ACCESSIBILE SOLO ALL'INTERNO DELLA CLASSE
        public string Cognome { get; set; } = "Bianchi";
        //string Cognome {get; set;} = "Bianchi"; -> PROPRIETA' ACCESSIBILE SOLO ALL'INTERNO DELLA CLASSE
        public DateTime DataNascita { get; } = DateTime.Now;

        //public string CodiceFiscale { get { return CalcolaCodiceFiscale(); } }
        public string CodiceFiscale { get { return Nome.Substring(0, 3) + Cognome.Substring(0, 3) + DataNascita.Year; } }
        //METODI

        private string CalcolaCodiceFiscale()
        {
            return Nome.Substring(0, 3) + Cognome.Substring(0, 3) + DataNascita.Year;
        }

        public virtual string NomeCompleto()
        {
            return $"Nome: {Nome} - Cognome: {Cognome} - Data Nascita: {DataNascita}";
        }

    }
}
