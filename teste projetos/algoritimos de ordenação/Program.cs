using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace algoritimos_de_ordenação;

class Program
{
   public static void Main(string[] args)
    {
        Stopwatch cron = new Stopwatch();
        int[] items = new int [2000];
        Random r = new Random();
            for(int i =0; i < items.Length; i++)
            {
            items[i] = r.Next(1,5000);
            } 

        // codigo para ordenação
        cron.Start();
        InsertionSort(items);
        cron.Stop();

        Console.WriteLine($"{cron.ElapsedMilliseconds / 1000} segundos");
        for(int j =0; j < items.Length; j++)
        {
            Console.WriteLine($"{items[j]}");
        }
        Console.WriteLine("Insira um valor para buscar no vetor");
        int num = Convert.ToInt32(Console.ReadLine());
        int posicao = PosicaoVetor(num,items);
        Console.WriteLine($"o numero está na posição {posicao} ");
    }

//busca de posicação //////////////////////////////////
public static int PosicaoVetor(int num, int[] items)
{
    for(int i = 0;i < items.Length;i++)
    {
        if(items[i] == num)
        {
            return i;
        }
    }
    return -1;
}



// Insertion sort /////////////////////////////////////////
//pouco melhor que bubbleSort
public static void InsertionSort(int[] items)
{
    int tamanho = items.Length;
    for(int posicao = 1; posicao < tamanho; posicao++)
    {
        int item = items[posicao];
        int anterior = posicao -1;

        while(anterior >= 0 && items[anterior] > item)
        {
            items[anterior + 1] = items[anterior];
            anterior = anterior -1;
        }
        items[anterior + 1] = item;
    }
}


// método selctionSort ///////////////////////////////

public static int[] SelectionSort(int[] items)
{
    int todositems = items.Length;
    for(int i =0; i < todositems -1; i++)
    {
        int posMenorItem = i;
        for(int j = i+1; j < todositems; j++)
        {
            if(items[j] < items[posMenorItem])
            {
                posMenorItem = j;
            }
        }

    int temp = items[posMenorItem];
    items[posMenorItem] = items[i];
    items[i] = temp;
    }
    return items;
}

//MergeSort /////////////////////////////////////// dificil
 
// ordenação
public void ordenar(int[] items, int esquerda, int direita)
{
    if(esquerda < direita)
    {
        int meio = esquerda + (direita - esquerda) / 2;

        ordenar(items,esquerda,meio);
        ordenar(items,meio + 1, direita);
        merge(items, esquerda,meio,direita);
    }
}

//Merge
private void merge(int[] arr, int l, int m, int r)
{
    int n1 = m - l + 1;
    int n2 = r - m;

    int[] L = new int[n1];
    int[] R = new int[n2];
    int i, j;

    for(i= 0; i < n1; i++)
    {
        L[i] = arr[l + i];
    }

    for(j = 0; j < n2; j++)
    {
        R[j] = arr[m + 1 + j];
    }

    i = 0;
    j = 0;
    int k = l;


    while(i < n1 && j < n2)
    {
        if(L[i] <= R[j])
        {
            arr[k] = L[i];
            i++;
        }
        else
        {
            arr[k] = R[j];
            j++;
        }
    k++;
    }

    while(i < n1)
    {
        arr[k] = L[i];
        i++;
        k++;
    }

    while(j < n2)
    {
        arr[k] = R[j];
        j++;
        k++;
    }
}

// QuickSort //////////////////////////////////////////////////////////
void quicksort(int[] items, int inicio, int fim)
{
    if(inicio < fim)
    {
        int pi = particionar(items, inicio, fim);
        quicksort(items,inicio, pi -1);
        quicksort(items,pi + 1, fim);
    }
}
int particionar(int[] items, int inicio, int fim)
{
    int pivot = items[fim];
    int i = (inicio - 1);

    for(int j = inicio; j <= fim -1;j++)
    {
        if(items[j] < pivot)
        {
            i++;
            trocar(items, i ,j);
        }
        
    }
    trocar(items, i+1, fim);
        return(i+1);
}

void trocar(int[] items, int i, int j)
    {
        int temp = items[i];
        items[i]= items[j];
        items[j] = temp;
    }
}

