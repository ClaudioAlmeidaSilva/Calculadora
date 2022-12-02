using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraApp
{
    public class Operacoes : IOperacoes
    {
        public int Adicao(int v1, int v2)
        {
            return v1 + v2;
        }
        public int Subtracao(int v1, int v2)
        {
            return v1 - v2;
        }

        public int Mutiplicacao(int v1, int v2)
        {
            return v1 * v2;
        }

        public int Divisao(int v1, int v2)
        {
            return v1 / v2;
        }
    }
}
