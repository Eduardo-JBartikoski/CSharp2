using System;


class Program
{
    

    static void Main(string[] args)
    {
        
        Funcao func = new Funcao();
        
        
        while (true)
        {
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Funcao.EntradaProduto();
                    break;
                case "2":
                    Funcao.ListarProduto();
                    break;
                case "3":
                    Funcao.RemoverProduto();
                    break;
                case "4":
                    Funcao.AddEstoque();
                    break;
                case "5":
                    Funcao.TirarEstoque();
                    break;
                case "0":
                    Console.WriteLine("Você escolheu 'Sair'.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}