using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPratico_FundamentosCsharp;
internal class PlacaVeiculo
{
    public static void Executar()
    {
        Console.WriteLine("Digite a placa do veículo: ");
        string placa = Console.ReadLine();

        bool tamanho = placa.Length == 7;

        bool letras = 
            char.IsLetter(placa[0]) && 
            char.IsLetter(placa[1]) && 
            char.IsLetter(placa[2]);

        bool numeros = 
            char.IsDigit(placa[3]) && 
            char.IsDigit(placa[4]) && 
            char.IsDigit(placa[5]) && 
            char.IsDigit(placa[6]);

        if (tamanho && letras && numeros)

        {
            Console.WriteLine("É uma placa válida.");
        } else
        {
            Console.WriteLine("Não é uma placa válida.");
        }
    }
}
