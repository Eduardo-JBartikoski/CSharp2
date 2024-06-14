using System;
using System.Runtime.InteropServices;

namespace tabuada;

class Program
{

public static void Main(string[] args)
{
    Console.WriteLine("Digite um número:");
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"A tabuada de {numero} é: ");
    ImprimirTabuada(numero, 1);
    
    
}

public static void ImprimirTabuada(int numero, int multiplicador)
{
    
    Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");
    if(multiplicador < 10)
    {
        ImprimirTabuada(numero, multiplicador + 1);        
        
    }

    else
    {
        Console.WriteLine("Deseja continuar? (s/n)");
        string resposta = Console.ReadLine().ToLower();
        if(resposta == "s")
        {
            Console.WriteLine("Digite um número:");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A tabuada de {numero} é: ");
            ImprimirTabuada(numero, 1);
        }
        else
        {
            Console.WriteLine($"Programa encerrado!");
        }
    }
    
}
}