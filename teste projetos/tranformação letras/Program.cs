
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá! Por favor, digite uma palavra:");
        string palavra = Console.ReadLine();
        string resultado = "";

        foreach (char letra in palavra)
        {
            // Conta quantas vezes a letra aparece na palavra
            int contador = 0;
            foreach (char caractere in palavra)
            {
                if (letra == caractere)
                {
                    contador++;
                }
            }

            // Se a letra se repetir, adiciona ")" ao resultado, caso contrário, adiciona "("
            if (contador > 1)
            {
                resultado += ")";
            }
            else
            {
                resultado += "(";
            }
        }

        Console.WriteLine(resultado);
    }
}