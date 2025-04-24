using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversorjoao
{
    internal class Conversor
    {
        public double resultado;

        public double ConvertDolar(double reais, double CotacaoDolar)
        {
            resultado = reais / CotacaoDolar;
            return resultado;
        }
        public double ConvertPeruano(double reais, double CotacaoPeruano)
        {
            resultado = reais * CotacaoPeruano;
            return resultado;
        }
    }
}
