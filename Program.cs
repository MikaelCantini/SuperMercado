using SuperMercado.Models;

namespace Program;

public class Program
{
    public static void Main()

    {
        List<Produto> produtos = new List<Produto>();
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
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {   
                    Console.WriteLine("====================================================================="); 
                    switch (opcaoSelecionada)
                    {   
                        case 1:

                            Produto produto = new Produto();
                            Console.WriteLine("\nPreencha os dados do produto: ");
                            Console.Write("\nId: ");
                            try
                            {
                                produto.Id = Convert.ToInt32(Console.ReadLine());
                                bool jaExiste = produtos.Exists(u => u.Id == produto.Id);
                                if (jaExiste)
                                {
                                    Console.WriteLine("ERRO , O ID INFORMADO JA EXISTE NO SISTEMA");
                                }
                            }
                            catch (FormatException)
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
                            
                            Console.Write("Preco de compra: ");
                            try
                            {
                                produto.PrecoCompra = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nERRO, Valor invalido, tente novamente");
                                break;
                            }
                            Console.Write("Preco de Venda: ");
                            try
                            {
                                produto.PrecoVenda = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nERRO, Valor invalido, tente novamente");
                                break;
                            }
                            produtos.Add(produto);
                            break;

                        case 2:
                            Console.Write("Digite o ID do produto para remover do sistema: ");
                            try
                            {
                                int idParaRemover = Convert.ToInt32(Console.ReadLine());
                                Produto nomeDeletado = produtos.Find(u => u.Id == idParaRemover);
                                produtos.RemoveAll(u => u.Id == idParaRemover);  
                                Console.WriteLine($"Produto {nomeDeletado.Nome} Removido com sucesso");
                                
                            }
                            catch(Exception)
                            {
                                Console.WriteLine("ERRO, valor invalido, verifique se o valor existe ou foi digitado certo");
                            }
                            break;
                        case 3:
                            foreach(Produto produto1 in produtos)
                            {
                                Console.WriteLine($"Id: {produto1.Id}");
                                Console.WriteLine($"Nome: {produto1.Nome}");
                                Console.WriteLine($"Preco de Compra: {produto1.PrecoCompra}");
                                Console.WriteLine($"Preco de Venda: {produto1.PrecoVenda}");
                                Console.WriteLine("=====================================================================");
                            }
                            break;
                        case 4:
                            repeteSistema = false;
                            break;


                    }
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("\nValor invalido , tente novamente");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

    }
}
