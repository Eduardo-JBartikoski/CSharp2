namespace teste_foreach;

class Program
{
    static void Main(string[] args)
    {
        string str = "Dermatoglyphics";
        string palavra;
        foreach(char c in str)
        {
            palavra = c.ToString();
        }
        Console.WriteLine(palavra);
    }
}
