

using System.Collections;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
       Menu menu = new Menu();
       menu.MeuMenu();
       
    }
}
class Menu
{
    Vender vender = new Vender();
    public int MeuMenu()
    {
    Console.WriteLine($"Alugar Casa Dígite: 1!");
    Console.WriteLine($"Vender Casa Dígite: 2!");
    Console.WriteLine($"Financiar Casa Dígite: 3!");
    Console.WriteLine($"Consultar casas a venda");
    int escolha;
        if(int.TryParse(Console.ReadLine(), out escolha))
        {
            switch(escolha)
            {
                case 1:
                   
                    Console.WriteLine("Você escolheu alugar");
                    break;
                    
                case 2:
                   Vender vendas = new Vender();
                    Console.WriteLine("Você escolheu Vender");
                    Console.WriteLine("Qual Rua?");
                    vendas.Rua = Console.ReadLine();
                    Console.WriteLine("Qual Número?");
                    vendas.Numero = Console.ReadLine();
                    Console.WriteLine("Qual Cidade?");
                    vendas.Cidade = Console.ReadLine();
                    Console.WriteLine("Qual Estado?");
                    vendas.Estado = Console.ReadLine();
                    break;
                case 3:
            
                    Console.WriteLine("Você escolheu Financiar");
                    break;
                case 4:
                    Console.WriteLine("Casas a Venda");

            }
            
        }
        return escolha;
    }
}

class Vender
{
    Vender[] vendas = new Vender[0];
   string NovoVetor[] novoVetor = new NovoVetor[];
    string novoVetor =  
    
public string Rua {get;set;}
public string Numero {get;set; }
public string Cidade {get;set; }
public string Estado {get;set; }

   

}




