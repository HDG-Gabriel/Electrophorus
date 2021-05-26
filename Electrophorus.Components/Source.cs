namespace Electrophorus.Components
{
    public class Source
    {
        public double Tensao { get; set; }
        public double Corrente { get; set; }
        public double Potencia { get; set; }

        public Source(double tensao)
        {
            Tensao = tensao;
        }

        private void CalcularPotencia()
        {
            Potencia = Tensao * Corrente;
        }
    }
}
