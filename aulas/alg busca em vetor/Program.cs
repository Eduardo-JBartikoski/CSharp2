namespace alg_busca_em_vetor;

class Program
{
    static void Main(string[] args)
    {
      int [] dados = {84,83,69,54,52,50,26,19,17,3};
      Array.Sort(dados);
      int valor_procurado = 54;
      bool valor_encontrado = false;
      int inicio = 0;
      int fim = dados.Length -1;
      int meio;

      do
      {
        meio = inicio +(fim - inicio) / 2;
        if(dados[meio] == valor_procurado)
        {
            Console.WriteLine("Valor encontrado no índice " + meio);
            valor_encontrado = true;
            break;
        } else if(dados[meio] > valor_procurado)
        {
            fim = meio - 1;
        } else 
        {
            inicio = meio + 1;
        }
      }  while(inicio <= fim);
            if(!valor_encontrado)
            {
                Console.WriteLine("Valor não encontrado");
            }
      
    }
}

//metodo 1
        /* int [] dados = {52,17,69,84,3,26,83,54,19,50};
        Console.WriteLine("Insira alguem valor: ");
        int valor_procurado = int.Parse(Console.ReadLine());
        bool valor_encontrado = false;

        for(int i=0; i < dados.Length; i++)
        {
            if(dados[i] == valor_procurado)
            {
                Console.WriteLine("Valor encontrado no índice "+i);
                valor_encontrado = true;
                break;
            }
        }
        if(!valor_encontrado)
        {
            Console.WriteLine("Valor não encontrado");
        }
    } */
