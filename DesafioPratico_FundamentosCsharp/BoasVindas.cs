using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPratico_FundamentosCsharp;

public class BoasVindas
{
    public static void Executar()
    {
        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine("Bem vindo " + nome + " " + sobrenome + "!");
    }
}