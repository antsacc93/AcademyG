using AcademyG.Week1.EsercitazioneFinale.Entities;

namespace AcademyG.Week1.EsercitazioneFinale.Factory
{
    public class Vitto : ICategoria
    {
        public string Nome { get; set; } = "Vitto";

        public double GetRimborso(Spesa spesa)
        {
            return spesa.Importo * 0.70;
        }
    }
}