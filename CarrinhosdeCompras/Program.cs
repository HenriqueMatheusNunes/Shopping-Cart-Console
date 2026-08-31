using System.Collections.Generic;

namespace CarrinhosdeCompras
{
    internal class Program
    {
        enum Opcao { Adicionar = 1, Listar = 2, RemoverItem = 3, CalcularTotal = 4, LimparCarrinho= 5, Sair = 6 }
        static void Main(string[] args)
        {
            List<ItemCarrinho> Lista = new List<ItemCarrinho>();
         
            bool rodarMenu = true;
            while (rodarMenu == true)
            {

                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("1-Adicionar\n2-Listar\n3-RemoverItem\n4-CalcularTotal\n5-LimparCarrinho\n6-Sair");

                int index = int.Parse(Console.ReadLine());
                Opcao opcaoSelecionada = (Opcao)index;

                switch (opcaoSelecionada)
                {

                    case Opcao.Adicionar:
                        Produto produto = new Produto();
                        ItemCarrinho quantidade = new ItemCarrinho();

                        Console.WriteLine("Qual o nome do produto que voce quer adicionar? ");
                        string nome = Console.ReadLine();
                        produto.Nome = nome;

                        Console.WriteLine("Digite  o preço: ");
                        decimal preco = decimal.Parse(Console.ReadLine());
                        produto.Preco = preco;

                        Console.WriteLine("Digite  a quantidade: ");
                        int qnt = int.Parse(Console.ReadLine());
                        quantidade.Quantidade = qnt;
                        quantidade.Produto = produto;

                        Lista.Add(quantidade);
                        Console.WriteLine($"Produto cadastrado: {produto.Nome} | Preço: {produto.Preco} + | Quantidade: {quantidade.Quantidade}");

                        break;

                    case Opcao.Listar:

                        Console.WriteLine("Vamos listar os produtos  cadastrados");




                        for (int i = 0; i < Lista.Count; i++)
                        {
                            Console.WriteLine($"{i} - Nome: {Lista[i].Produto.Nome} | Preço: R$ {Lista[i].Produto.Preco} | Qtd: {Lista[i].Quantidade} | Subtotal: R$ {Lista[i].Produto.Preco * Lista[i].Quantidade}");

                        }

                        break;
                case Opcao.RemoverItem:
                        Console.Write("\nDigite o número (índice) do item que deseja remover: ");

                        for (int i = 0; i < Lista.Count; i++)
                        {
                            Console.WriteLine($"{i} - Nome: {Lista[i].Produto.Nome} | Preço: R$ {Lista[i].Produto.Preco} | Quantidade: {Lista[i].Quantidade}");
                        }

                        if (int.TryParse(Console.ReadLine(), out int iEscolhido))
                        {
                            // Validação: Garante que o usuário digitou um índice que  existe no array
                            if (iEscolhido >= 0 && iEscolhido < Lista.Count)
                            {
                                Console.WriteLine("Produto removido com sucesso!");
                                Lista.RemoveAt(iEscolhido);
                            }
                            else
                            {
                                Console.WriteLine("Índice inválido!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Digite um número válido!");
                        }



                        break;

                    case Opcao.CalcularTotal:
                        decimal totalGeral = 0;

                       

                                for (int i = 0; i < Lista.Count; i++)
                            {
                            totalGeral += Lista[i].Produto.Preco * Lista[i].Quantidade;
                        }

                                Console.WriteLine("Valor total é " + totalGeral);




                        break;

                    case Opcao.LimparCarrinho:
                        
                          
                                
                                Lista.Clear();
                            
                           



                        break;












                    case Opcao.Sair:
                        rodarMenu = false;
                        break;















                }

                



                       

                       




                     
                       




                        













                














                }
            }
    }
}
