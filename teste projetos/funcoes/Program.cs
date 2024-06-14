namespace funcoes;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculadora");

        int n1 = PedirNumero();
        int n2 = PedirNumero();
        int n3 = PedirNumero();

        int res = n1 * n2 * n3;
        Console.WriteLine(res);
    }

    public static int PedirNumero()
    {
        Console.WriteLine("Insira um numero");
        int numero = Convert.ToInt32(Console.ReadLine());
        return numero;
    }
}
