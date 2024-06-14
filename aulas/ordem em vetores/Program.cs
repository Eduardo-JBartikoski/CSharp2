namespace ordem_em_vetores;

class Program
{
    static void Main(string[] args)
{
    // Ordenação por inserção
    int[] vetor = { 99, 82, 50, 67, 90, 20, 71, 8, 21, 18 };
    int num, pos_verificada;
    for(int pos = 1; pos < vetor.Length; pos++)
    {
        num = vetor[pos];
        pos_verificada = pos-1;

        while(pos_verificada >= 0 && num < vetor[pos_verificada])
        {
            vetor[pos_verificada +1] = vetor [pos_verificada];
            pos_verificada--; 

        }
        vetor[pos_verificada + 1] = num;
    }
    for(int i=0;i< vetor.Length; i++)
    {
        Console.WriteLine($"{i} vetor numero {vetor[i]}");
    }
}
}






            // método bolha
  /* int[] vetor = {99,82,50,67,90,20,71,8,21,18};
        bool mudou = true;
        int ultimo = vetor.Length-1;
        int ultimo_temp = vetor.Length-1;

        while(mudou)
        {
            int pos = 0;
            mudou = false;
            int temp = 0;
            while(pos<ultimo)
            {
                if(vetor[pos] > vetor[pos+1])
                {
                    temp = vetor[pos];
                    vetor[pos] = vetor[pos+1];
                    vetor[pos + 1] = temp;
                    mudou = true;
                    ultimo_temp = pos;
                }
                pos++;
            }
            ultimo = ultimo_temp;
        }

        for(int num = 0; num < vetor.GetLength(0); num++){
            Console.WriteLine($"vetor em orgem {vetor[num]}");
        } */






                    // Ordenação por seleção
    /*  int[] vetor = {99, 82, 50, 67, 90, 20, 71, 8, 21, 18};
    int min , temp;
    for(int i= 0; i < vetor.Length - 1; i++)
    {
        min = i;
        for(int pos = (i + 1); pos < vetor.Length; pos++)
        {
            if(vetor[pos] < vetor[min])
            {
            min = pos;
            }
        }
        if(vetor[i] != vetor[min])
        {
            temp = vetor[i];
            vetor[i] = vetor[min];
            vetor[min] = temp;
        }
    }
    for(int num = 0; num < vetor.GetLength(0); num++)
    {
        Console.WriteLine($"{num}orgem do vetor {vetor[num]}");
    } */