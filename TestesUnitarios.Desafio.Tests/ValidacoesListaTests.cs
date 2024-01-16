using System.Collections.Generic;

namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var novaLista = new List<int>();

            foreach (var elemento in lista)
            {
                if (elemento >= 0)
                {
                    novaLista.Add(elemento);
                }
            }

            return novaLista;
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            return lista.Contains(numero);
        }

        public List<int> MultiplicarElementosPorDois(List<int> lista)
        {
            var resultado = new List<int>();

            foreach (var elemento in lista)
            {
                resultado.Add(elemento * 2);
            }

            return resultado;
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            int maiorNumero = int.MinValue;

            foreach (var elemento in lista)
            {
                if (elemento > maiorNumero)
                {
                    maiorNumero = elemento;
                }
            }

            return maiorNumero;
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            int menorNumero = int.MaxValue;

            foreach (var elemento in lista)
            {
                if (elemento < menorNumero)
                {
                    menorNumero = elemento;
                }
            }

            return menorNumero;
        }
    }
}
