using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPratico_FundamentosCsharp;
internal class ContaCaracteres
{
    public static void Executar()
    {
        Console.WriteLine("Digite uma ou mais palavras: ");
        string palavra = Console.ReadLine();

        int caracteres = palavra.Count(c => !char.IsWhiteSpace(c));
        Console.WriteLine(palavra + " tem " + caracteres + " caracteres");
    }
}
