namespace Electrophorus.Components
{
    public class Resistor
    {
        public int Resistencia { get; set; }
        public double Corrente { get; set; }
        public double Tensao { get; set; }
        public double Potencia { get; set; }

        public Resistor(int resistencia) => Resistencia = resistencia;

        private void CalcularTensao(bool usarLeiDeOhm = true)
        {
            Tensao = Resistencia * Corrente;
        }

        private void CalcularCorrente()
        {
            Corrente = Tensao / Resistencia;
        }

        private void CalcularPotencia()
        {
            Potencia = Resistencia * Corrente;
        }
    }
}
