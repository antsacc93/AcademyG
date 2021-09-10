using AcademyG.Week1.EsercitazioneFinale.Entities;

namespace AcademyG.Week1.EsercitazioneFinale.Factory
{
    public class Altro : ICategoria
    {
        public string Nome { get; set; } = "Altro";

        public double GetRimborso(Spesa spesa)
        {
            return spesa.Importo * 0.1;
        }
    }
}