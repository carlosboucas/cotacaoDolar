namespace CotacaoDolar
{
    class Cotacao
    {
        public static double cot = 0.06;
        public static double cotDolar = 0;
        public static double compReais = 0;

        public static double CalcCotacao(double cotDolar, double compReais)
        {
            double mult = cotDolar * compReais;
            double cotacao = mult * cot;
            return mult + cotacao;
        }
    }
}
