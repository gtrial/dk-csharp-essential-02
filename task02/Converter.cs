namespace task02
{
    public class Converter
    {
        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }

        public double Usd { get; set; }
        public double Eur { get; set; }
        public double Rub { get; set; }
    }
}
