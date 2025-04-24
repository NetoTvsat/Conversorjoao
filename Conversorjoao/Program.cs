using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversorjoao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorReal, valorDolar, valorPeruano;

            Conversor conversor = new Conversor();

            Console.WriteLine("Informe um valor em reais:");
            valorReal = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a cotação atual do dólar:");
            valorDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a cotação atual do soles Peruano:");
            valorPeruano = double.Parse(Console.ReadLine());

            Console.WriteLine($"Dólar:{conversor.ConvertDolar(valorReal,valorDolar)}");
            Console.WriteLine($"Soles peruano:{conversor.ConvertPeruano(valorReal, valorPeruano)}");
        }
    }
}
