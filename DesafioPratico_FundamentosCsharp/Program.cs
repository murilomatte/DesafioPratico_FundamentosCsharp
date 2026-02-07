namespace DesafioPratico_FundamentosCsharp;

class Program
{
    static void Main()
    {
        {
            Console.WriteLine("1 - Boas Vindas");
            Console.WriteLine("2 - Calculadora Simples");
            Console.WriteLine("3 - Contar Caracteres");
            Console.WriteLine("4 - Verificar placa de veículo");
            Console.WriteLine("5 - Data Atual");
            Console.Write("Escolha: ");

            string escolha = Console.ReadLine();

            if (escolha == "1")
                BoasVindas.Executar();
            else if (escolha == "2")
                CalculadoraSimples.Executar();
            else if (escolha == "3")
                ContaCaracteres.Executar();
            else if (escolha == "4")
                PlacaVeiculo.Executar();
            else if (escolha == "5")
                DataAtual.Executar();
            else
            {
                Console.WriteLine("Opção inválida! Escolha um número entre 1 e 5.");
            }
        }
    }
}