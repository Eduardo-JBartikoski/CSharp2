

using System.Runtime.CompilerServices;

public class  FuncEstoque{
    
    Roupa[] roupas = new Roupa[0];


            //       NOVO
    public void AdicionarProduto(Roupa roupa)
    {

        roupa.Codigo = roupas.Length + 1;
        Roupa[] novoVetor = new Roupa[roupas.Length +1 ];
        for(int pos = 0; pos < roupas.Length; pos++)
        {
            Roupa item = roupas[pos];
            novoVetor[pos] = item;
            
            
        }

        novoVetor[novoVetor.Length - 1] = roupa;
        roupas = novoVetor;
        Console.WriteLine("Roupa adicionada");
    }

    public void Listar()
    {
        int cont = 1;
        
                foreach(Roupa item in roupas)
                {
                    Console.WriteLine($"{cont}-{item.Produto}   Tamanho: {item.Tamanho} Marca: {item.Marca} \nCor: {item.Cor}   Valor: (R${item.Preco}) - {item.Estoque} no estoque");
                    Console.WriteLine("________________________");
                    cont++;
                }
    }

    public void RemoverProduto()
    {
        Console.WriteLine("Informe Codigo do produto a ser removido");
        int codigo = Convert.ToInt32(Console.ReadLine());
        
                
                if(codigo >= 1 && codigo <= roupas.Length)
                {
                    Roupa[] novoVetor = new Roupa[roupas.Length - 1];
                    int novoindice = 0;
                    for(int cont = 0; cont <roupas.Length; cont ++)
                    {
                        if(roupas[cont].Codigo != codigo)
                        {
                            novoVetor[novoindice]= roupas[cont];
                            novoindice++;
                        }
                    }
                 roupas = novoVetor;
                 Console.WriteLine("Produto removido com sucesso");   
                }
                else {
                    Console.WriteLine("Codigo do produto inválido");
                }

                 
        

    }

    public void EntradaEstoque(int pos, int qtd)
    {
        
        roupas[pos - 1].Estoque += qtd;
        Console.WriteLine("Quantidade alterada com sucesso!");
       
    }

    public void SaidaEstoque(int pos, int qtd)
    {
        int qtdAtual = roupas[pos - 1].Estoque;
        roupas[pos - 1].Estoque = qtd;
        if(qtd > qtdAtual)
        {
            Console.WriteLine("Estoque insuficiente");
        }
        else 
        {
            
            Console.WriteLine("Quantidade alterada com sucesso!");
        }


        
    }
}