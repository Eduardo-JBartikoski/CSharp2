/* using System;


class Program
{
        private string[,] estoque = new string[5, 5];
    static void Main(string[] args)
    {
        

        Console.WriteLine("Controle de estoque - ");
        while (true)
        {
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                   EntradaProduto();
                    break;
                case "2":
                    ListarProduto();
                    break;
                case "3":
                    RemoverProduto();
                    break;
                case "4":
                    AddEstoque();
                    break;
                case "5":
                    TirarEstoque();
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

    
       
        
    
    // Lista de produtos
    public void ListarProduto()
    {
        Console.WriteLine(":::Produtos no estoque");
        Console.WriteLine("------------------" );

        for (int i = 0; i < estoque.GetLength(0); i++)
        {
            if (estoque[i, 0] != null)
            {
                
                Console.WriteLine($"{i + 1} . {estoque[i, 0]}  Tamanho: {estoque[i,3]}  Cor: {estoque[i,4]}  (R${estoque[i, 2]}) - Estoque: {estoque[i, 1]}");
            }
        }
    }
    

        // remover os produtos
    public static void RemoverProduto()
    {
        Console.WriteLine("Informe o Produto");
        int codigoProduto = Convert.ToInt32(Console.ReadLine());
        
        if(codigoProduto >= 1 && codigoProduto <= estoque.GetLength(0))
        {
            int indiceProduto = codigoProduto -1;

            for(int j=0; j < estoque.GetLength(1); j++)
            {
                estoque[indiceProduto, j] = null;
            }
            Console.WriteLine("Produto removido com sucesso");
            for (int i = indiceProduto; i < estoque.GetLength(0) - 1; i++)
        {
            if (estoque[i + 1, 0] != null)
            {
                for (int j = 0; j < estoque.GetLength(1); j++)
                {
                    estoque[i, j] = estoque[i + 1, j];
                    estoque[i + 1, j] = null;
                }
            }
            else
            {
                break; 
            }
        }

        // Listar os produtos atualizados
        ListarProduto();           
            
    }      else
        {
            Console.WriteLine("Código de produto inválido");
        }
    }

    
    

    // Entrada dos produtos
    static void EntradaProduto()
    {
        Console.WriteLine("Informe o produto:");
        string produto = Console.ReadLine();

        Console.WriteLine("Informe Tamanho (P, M ou G):");
        string tamanho = Console.ReadLine();
        string tamanhomaiusculo = tamanho.ToUpper();
        

        Console.WriteLine("Informe Cor");
        string cor = Console.ReadLine();

        
        Console.WriteLine("Informe o Preço:");
        decimal preco = Convert.ToDecimal(preco);

        int posicao = EncontrarProximaPosicao();

       
        estoque[posicao, 0] = produto;
        estoque[posicao, 1] = "0";
        estoque[posicao, 3] = tamanhomaiusculo;
        estoque[posicao, 4] = cor;
        estoque[posicao, 2] = preco("F2");
        

        

        Console.WriteLine("Produto cadastrado com sucesso!");
    }


    // Posicao dos produtos
    static int EncontrarProximaPosicao()
    {
        
        for (int i = 0; i < estoque.GetLength(0); i++)
        {
            if (estoque[i, 0] == 0)
            {
                return i;
            }
        }
        
        Console.WriteLine("Estoque cheio. Não é possível adicionar mais produtos.");
        return -1;
    }


        // adicionar estoque
      static void AddEstoque()
    {
        
        Console.WriteLine("Código do Produto:");
        int codigoProduto = Convert.ToInt32(Console.ReadLine());

        if(codigoProduto >= 1 && codigoProduto <= estoque.GetLength(0))
        {
            int indiceProduto = codigoProduto - 1;
            Console.WriteLine("qtd:");
            int novaQuantidade = Convert.ToInt32(Console.ReadLine());
            estoque[indiceProduto,1] = novaQuantidade;
            Console.WriteLine("Quantidade de estoque atualizada com sucesso!");
            return;
        }
            
        Console.WriteLine("Produto não encontrado no estoque.");       
        
        
        
        
    }

            // Remover estoque
     static void TirarEstoque() 
    {
        Console.WriteLine("Código do Produto:");
        int codigoProduto = Convert.ToInt32(Console.ReadLine());
         

        if (codigoProduto >= 1 && codigoProduto <= estoque.GetLength(0))
        {
            int indiceProduto = codigoProduto - 1;

            Console.WriteLine("Quantidade a ser retirada:");
            int retirarqtd = Convert.ToInt32(Console.ReadLine());

            int estoqueAtual = Convert.ToInt32(estoque[indiceProduto,1]);
            if(retirarqtd <= estoqueAtual)
            {
                estoque[indiceProduto,1] = Convert.ToInt32(estoqueAtual - retirarqtd);
                Console.WriteLine($"Estoque atualizado com Sucesso");
            } else
            {
                Console.WriteLine("Quantidade a ser retirada é maior que estoque do produto");
            }
        }

    }
*/ 
using System;

class Program
{
    string[,] estoque = new string[5, 5];

    static void Main(string[] args)
    {
        Console.WriteLine("Controle de estoque - ");
        while (true)
        {
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    EntradaProduto();
                    break;
                case "2":
                    ListarProduto();
                    break;
                case "3":
                    RemoverProduto();
                    break;
                case "4":
                    AddEstoque();
                    break;
                case "5":
                    TirarEstoque();
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

    // Lista de produtos
    public static void ListarProduto()
    {
        Console.WriteLine(":::Produtos no estoque");
        Console.WriteLine("------------------");

        for (int i = 0; i < estoque.GetLength(0); i++)
        {
            if (estoque[i, 0] != null)
            {
                Console.WriteLine($"{i + 1} . {estoque[i, 0]}  Tamanho: {estoque[i, 3]}  Cor: {estoque[i, 4]}  (R${estoque[i, 2]}) - Estoque: {estoque[i, 1]}");
            }
        }
    }

    // Remover os produtos
    public static void RemoverProduto()
    {
        Console.WriteLine("Informe o Produto");
        int codigoProduto = Convert.ToInt32(Console.ReadLine());

        if (codigoProduto >= 1 && codigoProduto <= estoque.GetLength(0))
        {
            int indiceProduto = codigoProduto - 1;

            for (int j = 0; j < estoque.GetLength(1); j++)
            {
                estoque[indiceProduto, j] = null;
            }
            Console.WriteLine("Produto removido com sucesso");

            for (int i = indiceProduto; i < estoque.GetLength(0) - 1; i++)
            {
                if (estoque[i + 1, 0] != null)
                {
                    for (int j = 0; j < estoque.GetLength(1); j++)
                    {
                        estoque[i, j] = estoque[i + 1, j];
                        estoque[i + 1, j] = null;
                    }
                }
                else
                {
                    break;
                }
            }

            // Listar os produtos atualizados
            ListarProduto();
        }
        else
        {
            Console.WriteLine("Código de produto inválido");
        }
    }

    // Entrada dos produtos
    static void EntradaProduto()
    {
        Console.WriteLine("Informe o produto:");
        string produto = Console.ReadLine();

        Console.WriteLine("Informe Tamanho (P, M ou G):");
        string tamanho = Console.ReadLine();
        string tamanhomaiusculo = tamanho.ToUpper();

        Console.WriteLine("Informe Cor");
        string cor = Console.ReadLine();

        Console.WriteLine("Informe o Preço:");
        decimal preco = Convert.ToDecimal(Console.ReadLine());

        int posicao = EncontrarProximaPosicao();

        estoque[posicao, 0] = produto;
        estoque[posicao, 1] = "0";
        estoque[posicao, 3] = tamanhomaiusculo;
        estoque[posicao, 4] = cor;
        estoque[posicao, 2] = preco.ToString("F2");

        Console.WriteLine("Produto cadastrado com sucesso!");
    }

    // Posicao dos produtos
    static int EncontrarProximaPosicao()
    {
        for (int i = 0; i < estoque.GetLength(0); i++)
        {
            if (estoque[i, 0] == null)
            {
                return i;
            }
        }

        Console.WriteLine("Estoque cheio. Não é possível adicionar mais produtos.");
        return -1;
    }

    // Adicionar estoque
    static void AddEstoque()
    {
        Console.WriteLine("Código do Produto:");
        int codigoProduto = Convert.ToInt32(Console.ReadLine());

        if (codigoProduto >= 1 && codigoProduto <= estoque.GetLength(0))
        {
            int indiceProduto = codigoProduto - 1;
            Console.WriteLine("Quantidade:");
            string novaQuantidade = Console.ReadLine();
            estoque[indiceProduto, 1] = novaQuantidade;
            Console.WriteLine("Quantidade de estoque atualizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado no estoque.");
        }
    }

    // Remover estoque
    static void TirarEstoque()
    {
        Console.WriteLine("Código do Produto:");
        int codigoProduto = Convert.ToInt32(Console.ReadLine());

        if (codigoProduto >= 1 && codigoProduto <= estoque.GetLength(0))
        {
            int indiceProduto = codigoProduto - 1;

            Console.WriteLine("Quantidade a ser retirada:");
            string retirarqtd = Console.ReadLine();

            int estoqueAtual = Convert.ToInt32(estoque[indiceProduto, 1]);
            if (Convert.ToInt32(retirarqtd) <= estoqueAtual)
            {
                estoque[indiceProduto, 1] = (estoqueAtual - Convert.ToInt32(retirarqtd)).ToString();
                Console.WriteLine($"Estoque atualizado com Sucesso");
            }
            else
            {
                Console.WriteLine("Quantidade a ser retirada é maior que estoque do produto");
            }
        }
    }
}
