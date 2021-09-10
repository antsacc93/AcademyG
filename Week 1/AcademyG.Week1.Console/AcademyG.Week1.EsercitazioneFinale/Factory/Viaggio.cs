using AcademyG.Week1.EsercitazioneFinale.Entities;

namespace AcademyG.Week1.EsercitazioneFinale.Factory
{
    public class Viaggio : ICategoria
    {
        public string Nome { get; set; } = "Viaggio";

        public double GetRimborso(Spesa spesa)
        {
            return spesa.Importo + 50;
        }
    }
}