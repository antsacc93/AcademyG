using AcademyG.Week1.EsercitazioneFinale.Entities;

namespace AcademyG.Week1.EsercitazioneFinale.Factory
{
    public class Alloggio : ICategoria
    {
        public string Nome { get; set; } = "Alloggio";

        public double GetRimborso(Spesa spesa)
        {
            return spesa.Importo;
        }
    }
}