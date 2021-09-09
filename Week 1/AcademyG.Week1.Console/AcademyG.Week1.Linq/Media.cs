using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.Linq
{
    public class Media
    {
        public string NomeStudente { get; set; }
        public double MediaStudente { get; set; }

        public override string ToString()
        {
            return $"Nome: {NomeStudente} - Media: {MediaStudente}";
        }
    }
}
