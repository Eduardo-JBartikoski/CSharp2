namespace binari_search;

class Program
{
    static void Main(string[] args)
    {
        int [] elementos = new int[] {37,14,80,52,60,32,42,89,85,88};
        
        for (int i = 0; i < elementos.Length; i++)
        {
            Array.Sort(elementos);
            Console.WriteLine(elementos[i]);
        }
        
        int valor = 52;
        int indice = BuscaBinaria(elementos, valor);
        if(indice != -1)
        {
            Console.WriteLine($"o valor {valor} foi encontrado na posicação {indice}");

        }

        else 
        {
            Console.WriteLine($"O valor {valor} não foi encontrado");
        }
        
    }



public static int BuscaBinaria(int[] elementos, int valor)
{
    int inicio = 0;
    int fim = elementos.Length - 1;

    while(inicio <= fim)
    {
        int meio = inicio + (fim - inicio) / 2;

        if(elementos[meio] == valor)
        return meio;

        if(elementos [meio] < valor)
        inicio = meio + 1;

        else
         fim = meio - 1;
    }
    return -1;
}
}
