using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPratico_FundamentosCsharp;
internal class DataAtual
{
    public static void Executar()
    {
        DateTime agora = DateTime.Now;
        CultureInfo port = new CultureInfo("pt-BR");

        Console.WriteLine("\nFormato completo:");
        Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", port));

        Console.WriteLine("\nData:");
        Console.WriteLine(agora.ToString("dd/MM/yyyy"));

        Console.WriteLine("\nHora:");
        Console.WriteLine(agora.ToString("HH:mm:ss"));

        Console.WriteLine("\nData com mês por extenso:");
        Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", port));
    }
}
