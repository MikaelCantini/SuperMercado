using SuperMercado.Models;

namespace Program;

public class Program
{
    public static void Main()

    {
        Console.WriteLine("Seja bem vindo: ");
        bool repeteSistema = true;
        while(repeteSistema)
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("\n1. Adicionar Produto");
            Console.WriteLine("2. Remover Produto");
            Console.WriteLine("3. Estoque");
            Console.WriteLine("4. Sair");
            Console.Write("\nDigite o numero da opcao que deseja: ");
            try
            {
                int opcaoSelecionada = Convert.ToInt32(Console.ReadLine());
                if (opcaoSelecionada <= 0 || opcaoSelecionada >= 5)
                {
                    Console.WriteLine("Opcao selecionada nao existe, tente novamente");
                }
                else
                {
                    switch(opcaoSelecionada)
                    {
                        case 1:
                            Console.WriteLine("Preencha os dados do produto: ");
                            Console.WriteLine();
                            break;
                    }
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("\n Valor invalido , tente novamente");
            }
        }

    }
}
