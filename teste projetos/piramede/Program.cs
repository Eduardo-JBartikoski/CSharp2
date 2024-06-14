using System.Xml;

namespace piramede;

class Program
{
    static void Main(string[] args)
    {
       int [,] valores = new int[3,3];

        for(int i = 0; i < valores.Length; i++)
        {
            for(int c = 0; c < valores.Length; c++)
            {
                valores[i][c] = valores[i][c] + valores[c][i];
            }
            
        }
        Console.WriteLine(valores[2,2]);
       /* int altura = 5;

        for(int linha = 1;linha <= altura; linha++)
        {
            for(int espaco = 1; espaco <= altura - linha; espaco ++)
            {
                Console.Write(" ");
            }
            for(int asterisco = 1;asterisco <= 2 * linha - 1; asterisco++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        } */
    }
}
