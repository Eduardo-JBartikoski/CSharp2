namespace loop;

class Program
{
    static void Main(string[] args)
    {
        int cont = 0;
        string res = "verdade";
        do 
        {
            Console.WriteLine("você é bonito (verdadeiro ou falso)");
            string resposta = Console.ReadLine();
            if(resposta == res)
            {
                Console.WriteLine("Resposta correta");
                Console.WriteLine($" numero de tentativas -{cont} de 5:");

            }
            else
            {
                Console.WriteLine("Resposta errada");
                cont++;
                Console.WriteLine($"numero de tentativas - {cont} de 5:");
            }
        } while(cont < 5);
    }
}
