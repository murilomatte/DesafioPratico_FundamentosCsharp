using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPratico_FundamentosCsharp;
internal class CalculadoraSimples
{
    public static void Executar()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        int numero2 = int.Parse(Console.ReadLine());

        int soma = numero1 + numero2;
        Console.WriteLine("Resultado da soma: " + soma);

        int sub = numero1 - numero2;
        Console.WriteLine("Resultado da subtração: " + sub);

        int mult = numero1 * numero2;
        Console.WriteLine("Resultado da multiplicação: " + mult);

        if (numero2 != 0)
        {
            int div = numero1 / numero2;
            Console.WriteLine("Resultado da divisão: " + div);
        } else {
            Console.WriteLine("Impossível realizar divisão");
        }

            int med = soma / 2;
        Console.WriteLine("Resultado da média: " + med);
    }
}
