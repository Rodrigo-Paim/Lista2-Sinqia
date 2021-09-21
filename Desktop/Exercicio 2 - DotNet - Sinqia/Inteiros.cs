using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2___DotNet___Sinqia
{
    public class Inteiros
      {
            this.ExecutarOperacoes();
        }

        private int menorNumero = 0;
        private int maiorNumero = 0;
        void ExecutarOperacoes()
        {

            int[] matriz = GetMatriz();
            this.ExibirInformacoesMatriz(matriz);
            int[] matrizRandomica = this.GetMatrizRandomica();


            Console.WriteLine($"Matriz digitada: {String.Join(",", matriz)}");
            Console.WriteLine($"Matriz randomica: {String.Join(",", matrizRandomica)}");
            this.CompararMatrizes(matriz, matrizRandomica);

        }

        private int[] GetMatriz()
        {
            int[] inputNumeros = new int[10];
            int count = 0;
            Console.WriteLine("Insira n�meros at� digitar um n�mero primo ou termos 10 elementos");
            for (int i = 0; i < inputNumeros.Length; i++)
            {
                Console.WriteLine($"{i + 1}� n�mero");
                int input = SolicitarNumero();
                inputNumeros[i] = input;
                count++;
                if (isPrimo(input))
                {
                    Console.WriteLine("N�mero primo digitado, preenchimento finalizado");
                    break;
                }
            }
            int[] matriz = new int[count];
            for (int i = 0; i < matriz.Length; i++)
                matriz[i] = inputNumeros[i];
            return matriz;
        }

        private int SolicitarNumero()
        {
            bool numeroValido = false;
            int input = 0;

            while (!numeroValido)
            {
                numeroValido = int.TryParse(Console.ReadLine(), out input);
                if (!numeroValido)
                {
                    Console.WriteLine("N�mero inv�lido, entre um novo n�mero.");
                }

            };
            return input;
        }


        bool isPrimo(int numero)
        {
           
            if (numero == 1)
                return false;
            if (numero == 2)
                return true;

            for (int i = 2; i <= limiteMaximo; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        private void ExibirInformacoesMatriz(int[] matriz)
        {
            int qtdPar = 0;
            int qtdImpar = 0;

            maiorNumero = matriz[0];
            menorNumero = matriz[0];

            int totalMatriz = 0;

            foreach (int item in matriz)
            {
                if (item % 2 == 0)
                    qtdPar += 1;
                else
                    qtdImpar += 1;

                if (item < menorNumero)
                    menorNumero = item;

                if (item > maiorNumero)
                    maiorNumero = item;

                totalMatriz += item;
            }
            Console.WriteLine($"Quantidade de n�mero �mpares: {qtdImpar}");
            Console.WriteLine($"Quantidade de n�mero pares: {qtdPar}");
            Console.WriteLine($"Menor n�mero: {this.menorNumero}");
            Console.WriteLine($"Maior n�mero: {this.maiorNumero}");
            Console.WriteLine($"TotalMatriz: {totalMatriz}");
        }

        private int[] GetMatrizRandomica()
        {
            int[] matrizRandomica = new int[3];
            for (int i = 0; i < matrizRandomica.Length; i++)
                matrizRandomica[i] = new Random().Next(menorNumero, maiorNumero);
            return matrizRandomica;
        }

        private void CompararMatrizes(int[] matriz, int[] matrizRandomica)
        {
            if (matriz.Length < 3)
                return;
            string numerosComuns = "";

            foreach (int rnd in matrizRandomica)
            {
                foreach (int item in matriz)
                {
                    if (rnd == item)
                        numerosComuns += $"{item},";
                }
            }
            if (numerosComuns == "")
                Console.WriteLine($"N�o h� n�meros em comum entre as duas matrizes");
            else
                Console.WriteLine($"Os n�meros {numerosComuns.TrimEnd(',')} da matriz rand�mica est�o presentes na matriz do usu�rio");
        }

    }
}