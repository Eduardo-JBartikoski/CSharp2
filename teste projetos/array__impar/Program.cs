namespace array__impar;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor= new int[] {3,1,2,6,8,9,7,5,10,4};
        
        foreach(int impar in vetor)
        {
            if(impar % 2 == 1)
            {
        for(int i = 0; i< vetor.Length -1; i++)
        {
            int anterior = vetor[i];
            int posterior = vetor[i+1];
            if(posterior < anterior)
            {
                vetor[i] = posterior;
                vetor[i+1] = anterior;
            }






           
        }
            }
        }

        for(int numero = 0; numero < vetor.Length; numero++)
        {
            Console.WriteLine(vetor[numero]);
        }
    }
}
