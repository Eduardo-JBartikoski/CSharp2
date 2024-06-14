            
            
    class Funcao        
   {        
    
    public static string[,] estoque = new string[5, 5]; // Variável global para armazenar o estoque
    
    // Lista de produtos
    public static void ListarProduto()
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
        
        if(codigoProduto >= 1 && codigoProduto <=estoque.GetLength(0))
        {
            int indiceProduto = codigoProduto -1;

            for(int indice=0; indice<estoque.GetLength(1); indice++)
            {
                estoque[indiceProduto,indice] = null;
            }
            Console.WriteLine("Produto removido com sucesso");
            
            // reorganizar o produto

            for(int indice = indiceProduto; indice < estoque.GetLength(0) -1; indice++)
            {
                if(estoque[indice+1, 0] != null)
                {
                    for(int resto = 0; resto <estoque.GetLength(1); resto++)
                    {
                        estoque[indice,resto] = estoque[indice+1,resto];
                        estoque[indice+1,resto] = null;
                    }
                }
            }
        } 
        else
        {
            Console.WriteLine("Código de produto inválido");
        }
        
    }



 // Entrada dos produtos
    public static void EntradaProduto()
    {
        Console.WriteLine("Informe o Tipo de Produto (Camiseta, Calça, etc.)");
        string produto = Console.ReadLine();

        Console.WriteLine("Informe Tamanho (P, M, G ou tamanho específico para calças)");
        string tamanho = Console.ReadLine();
        string tamanhomaiusculo = tamanho.ToUpper();
        

        Console.WriteLine("Informe Cor");
        string cor = Console.ReadLine();

        
        Console.WriteLine("Informe o Preço:");
        decimal preco = decimal.Parse(Console.ReadLine());

        int posicao = EncontrarProximaPosicao();

       
        estoque[posicao, 0] = produto;
        estoque[posicao, 1] = "0";
        estoque[posicao, 3] = tamanhomaiusculo;
        estoque[posicao, 4] = cor;
        estoque[posicao, 2] = preco.ToString("F2");
        

        

        Console.WriteLine("Produto cadastrado com sucesso!");
    }


    // Posicao dos produtos
    public static int EncontrarProximaPosicao()
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


        // adicionar estoque
     public static void AddEstoque()
    {
        
        Console.WriteLine("Código do Produto:");
        int codigoProduto = Convert.ToInt32(Console.ReadLine());

        if(codigoProduto >= 1 && codigoProduto <= estoque.GetLength(0))
        {
            int indiceProduto = codigoProduto - 1;
            Console.WriteLine("qtd:");
            int novaQuantidade = Convert.ToInt32(Console.ReadLine());
            estoque[indiceProduto,1] = novaQuantidade.ToString();
            Console.WriteLine("Quantidade de estoque atualizada com sucesso!");
            return;
        }
            
        Console.WriteLine("Produto não encontrado no estoque.");       
        
        
        
        
    }

            // Remover estoque
    public static void TirarEstoque() 
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
                estoque[indiceProduto,1] = (estoqueAtual - retirarqtd).ToString();
                Console.WriteLine($"Estoque atualizado com Sucesso");
            } else
            {
                Console.WriteLine("Quantidade a ser retirada é maior que estoque do produto");
            }
        }

    }
   }