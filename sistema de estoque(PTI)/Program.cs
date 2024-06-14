namespace sistema_de_estoque_PTI_;

class Program
{
    static void Main(string[] args)
    {
       FuncEstoque funcao = new FuncEstoque();
       Roupa roupas = new Roupa();
       

    int opcao;
        do
        {
            
            Console.WriteLine("[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair");
            
            opcao = Convert.ToInt32(Console.ReadLine());

                // Novo Produto
        if (opcao == 1)
            {
                Roupa novaRoupa = new Roupa();
                
                Console.WriteLine("Informe o Produto:");
                novaRoupa.Produto = Console.ReadLine();

                Console.WriteLine("Informe Tamanho:");
                novaRoupa.Tamanho = Console.ReadLine();

                Console.WriteLine("Informe Cor:");
                novaRoupa.Cor = Console.ReadLine();

                Console.WriteLine("Informe Marca:");
                novaRoupa.Marca = Console.ReadLine();

                Console.WriteLine("Preço:");
                decimal precostr = decimal.Parse(Console.ReadLine());
                novaRoupa.Preco = precostr.ToString("F2");
                

                funcao.AdicionarProduto(novaRoupa);
                
            }
        else if (opcao == 2)
            {
                Console.WriteLine("\nItens no Estoque:");
                
               funcao.Listar();
            }
        else if (opcao == 3)
            {
                funcao.RemoverProduto();
            }
        else if (opcao == 4)
            {
                Console.WriteLine("\nItens no Estoque:");
               funcao.Listar();

                Console.WriteLine("Insira Codigo do produto:");
                int pos = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Insira quantidade:");
                int qtd = Convert.ToInt32(Console.ReadLine());

                funcao.EntradaEstoque(pos,qtd);
            }
        else if (opcao == 5)
            {
                Console.WriteLine("\nItens do Estoque");
                funcao.Listar();

                Console.WriteLine("Insira o Codigo do produto:");
                int pos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira Quantidade a ser removida:");
                int qtd = Convert.ToInt32(Console.ReadLine());

                funcao.SaidaEstoque(pos, qtd);
            }
        else if (opcao == 0) 
        {
            Console.WriteLine("Você escolheu sair!");
        }
        } 
        while (opcao != 0);
        
        
    }
}
