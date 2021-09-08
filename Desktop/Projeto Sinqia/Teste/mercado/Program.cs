using System;

namespace mercado
{
  class Program
  {
    static void Main(string[] args)
    {
      int qtLeite = 4;
      int qtOvos = 0;
      bool possuiOvos = true;
      bool levouCarteira = true;
      double precoLeite = 3.15;
      double precoOvo = 7.00;

      bool estaSol = true;
      bool possuiEstacionamentoCoberto = false;
      if (levouCarteira)
      {
        if (estaSol || possuiEstacionamentoCoberto)
        {
          if (possuiOvos && precoOvo < 6)
          {
            qtOvos = 6;
          }

          double precoTotalLeite = qtLeite * precoLeite;
          double precoTotalOvos = (precoOvo / 12) * qtOvos;
          double totalCompra = precoTotalLeite + precoTotalOvos;

          Console.WriteLine($"Quantidade de caixas de leites compradas: {qtLeite}");
          Console.WriteLine($"Quantidade de Ovos compradas: {qtOvos}");
          Console.WriteLine($"Total Leite: {precoTotalLeite}");
          Console.WriteLine($"Total Ovos: {precoTotalOvos}");
          Console.WriteLine($"Total da compra: {totalCompra}");
        }
        else
        {
          Console.WriteLine($"fica em casa");
        }
      }
      else
      {
        Console.WriteLine($"Não vendemos fiado");
        Environment.Exit(0);
      }

    }

  }
}
