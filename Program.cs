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
                            Produto produto = new Produto();
                            Console.WriteLine("\nPreencha os dados do produto: ");
                            Console.Write("\nId: ");
                            try
                            {
                                produto.Id = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException )
                            {
                                Console.WriteLine("\nERRO, Valor invalido, tente novamente!");
                                break;
                            }
                            Console.Write("Nome do Produto: ");
                            string nomeProduto = Console.ReadLine();
                            if (nomeProduto == "" || nomeProduto.IsWhiteSpace())
                            {
                                Console.WriteLine("\nNome do produto invalido, tente novamente!");
                                break;
                            }
                            else
                            {
                                produto.Nome = nomeProduto;
                            }
                            Console.Write("Quantos quer adicionar ao estoque: ");
                            try
                            {
                                int quantidadeAdicionarNoEstoque = Convert.ToInt32(Console.ReadLine());
                                if(quantidadeAdicionarNoEstoque <= 0)
                                {
                                    Console.WriteLine("\nERRO, DEVE HAVER PELO MENOS 1 UNIDADE DO PRODUTO PARA ADICIONAR");
                                    break;
                                }
                                else
                                {
                                    produto.QuantidadeParaAdicionarNoEstoque = quantidadeAdicionarNoEstoque;
                                }
                            }
                            catch(FormatException)
                            {
                                Console.WriteLine("\nErro, Valor invalido , tente novamente!");
                                break;

                            }
                            Console.Write("Preco de compra: ");
                            try
                            {
                                decimal precoDeCompra = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch(FormatException)
                            {
                                Console.WriteLine("\nERRO, Valor invalido, tente novamente");
                                break;
                            }
                            Console.Write("Preco de Venda: ");
                            try
                            {
                                decimal precoDeVenda = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch(FormatException)
                            {
                                Console.WriteLine("\nERRO, Valor invalido, tente novamente");
                                break;
                            }
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
