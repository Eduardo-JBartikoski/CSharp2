namespace matriz;

class Program
{
    static void Main(string[] args)
    {
       int [] valores = new int[];

        for(int i = 0; i < valores.Length; i++)
        {
            for(int c = 0; c < valores.Length; c++)
            {
                valores[i] = valores[i] + valores[i];
            }
            
        }
        Console.WriteLine(valores[2]);
    }
}
