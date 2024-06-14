using System.Reflection.Metadata.Ecma335;

namespace faculdade;

class Program
{
    static void Main(string[] args)
    {
        
        double n1 = PedirNota("Informe a nota 1: ");

        
        double n2 = PedirNota("Informe a nota 2: ");

        
        double n3 = PedirNota("Informe a nota 3: ");

        double media = CalcularMedia(n1,n2,n3);
        string sit = Situacao(media);
        
        Escrever("Sua nota Final é " + media);
        Escrever("Sua Situação é "+ sit);
    }





    public static void Escrever(string msg)
    {
        Console.WriteLine(msg);
    }

    public static double PedirNota(string msg)
    {
        Console.WriteLine(msg);
        double n = Convert.ToDouble(Console.ReadLine());
        return n;
    }

    public static double CalcularMedia(double n1, double n2, double n3)
    {
    double m = (n1 + n2 + n3) / 3;
        return m;
}
    public static string Situacao(double media){

        string sit= "";
        if(media >=6){
            sit = "Aprovado";
        } 
        else {
            sit = "Reprovado";
        }

        return sit;
    }
    
}

/*Console.WriteLine("Informe um valor: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe outro valor: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int soma = n1 + n2;
        Console.WriteLine($"a soma de {n1} + {n2} é {soma}");*/




        /*
       Escrever("Du");
       Escrever("Dudu");
       Escrever("Edu");

    }
    public static void Escrever(string nome){

        Console.WriteLine($"Olá {nome}");
*/