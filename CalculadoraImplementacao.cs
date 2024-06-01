using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImplementacao
    {
        private readonly List<String> listaHistorico;

        public CalculadoraImplementacao()
        {
            listaHistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            listaHistorico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            listaHistorico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            listaHistorico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }

            int resultado = num1 / num2;
            listaHistorico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }

        public List<String> Historico()
        {
            return new List<string> ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
        }
        
    }
}