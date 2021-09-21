using System;


namespace Exercicio_2___DotNet___Sinqia
{
  public class String
  {
    public AvaliacaoString()
    {
      this.ExecutarAvaliacao();
    }
    void ExecutarAvaliacao()
    {
      Console.WriteLine("Digite uma palavra ou frase");
      string strAvaliacao = Console.ReadLine();
      int tamanho = strAvaliacao.Length;
      Console.WriteLine("Operações com string");
      if (tamanho % 2 == 0)
      {
        Console.WriteLine($"Trocar vizinhas:{this.TrocarVizinhos(strAvaliacao)}");
      }
      else
      {
        Console.WriteLine($"Inverter:{this.Inverter(strAvaliacao)}");
      }
      Console.WriteLine($"É um palindromo?: {(this.IsPalindromo(strAvaliacao) ? "Sim" : "Não")}");
      Console.WriteLine($"Remover letras repetidas: {this.RemoverRepetidas(strAvaliacao)}");
    }

    string Inverter(string strAvaliacao)
    {
      string invertida = "";
      for (int i = strAvaliacao.Length - 1; i >= 0; i--)
      {
        invertida += strAvaliacao[i];
      }
      return invertida;
    }

    string TrocarVizinhos(string strAvaliacao)
    {
      string trocado = "";
      for (int i = 0; i < strAvaliacao.Length; i += 2)
      {
        trocado += strAvaliacao[i + 1];
        trocado += strAvaliacao[i];
      }
      return trocado;
    }

    bool IsPalindromo(string strAvaliacao)
    {

      return strAvaliacao == Inverter(strAvaliacao);
    }

    string RemoverRepetidas(string strAvaliacao)
    {
      string retorno = "";
      retorno += strAvaliacao[0];
      for (int i = 0; i < strAvaliacao.Length; i++)
      {
        bool achouLetra = false;
        for (int j = 0; j < retorno.Length; j++)
        {

          if (strAvaliacao[i] == retorno[j])
          {
            achouLetra = true;
            break;//break para sair do for, pois se ele ja achou a letra nao faz sentido continuar olhando
          }
        }
        if (!achouLetra)
        {
          retorno += strAvaliacao[i];
        }
      }
      return retorno;
    }
  }


}