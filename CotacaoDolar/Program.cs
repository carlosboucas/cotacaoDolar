using System;
using System.Globalization;

namespace CotacaoDolar
{
    class Program
    {
            static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólas? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double reais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = Cotacao.CalcCotacao(dolar, reais);

            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}