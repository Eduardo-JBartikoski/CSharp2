using System;
namespace jogodavelha 
{

class Program
{

    static char[,] tabuleiro = new char[3, 3]; // Matriz 3x3 para representar o tabuleiro
    static void Main(string[] args)
    {
         InicializarTabuleiro();

        bool jogadorX = true; // Indica se é a vez do jogador X

        while (true)
        {
            ExibirTabuleiro();

            Console.WriteLine($"É a vez do jogador {(jogadorX ? "X" : "O")}");

            Console.Write("Informe a linha (1-3): ");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("Informe a coluna (1-3): ");
            int coluna = int.Parse(Console.ReadLine());

            if (linha < 1-1 || linha > 3-1 || coluna < 1-1 || coluna > 3-1 || tabuleiro[linha, coluna] != ' ')
            {
                Console.WriteLine("Jogada inválida. Tente novamente.");
                continue;
            }

            tabuleiro[linha, coluna] = jogadorX ? 'X' : 'O';

            if (VerificarVitoria(jogadorX ? 'X' : 'O'))
            {
                ExibirTabuleiro();
                Console.WriteLine($"O jogador {(jogadorX ? "X" : "O")} venceu!");
                break;
            }

            if (VerificarEmpate())
            {
                ExibirTabuleiro();
                Console.WriteLine("O jogo empatou!");
                break;
            }

            jogadorX = !jogadorX; // Alternar jogador
        }
    }

    static void InicializarTabuleiro()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tabuleiro[i, j] = ' ';
            }
        }
    }

    static void ExibirTabuleiro()
    {
        Console.WriteLine(" 1 2 3");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tabuleiro[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool VerificarVitoria(char jogador)
    {
        // Verificar linhas e colunas
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[i, 0] == jogador && tabuleiro[i, 1] == jogador && tabuleiro[i, 2] == jogador)
                return true;
            if (tabuleiro[0, i] == jogador && tabuleiro[1, i] == jogador && tabuleiro[2, i] == jogador)
                return true;
        }

        // Verificar diagonais
        if (tabuleiro[0, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 2] == jogador)
            return true;
        if (tabuleiro[0, 2] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 0] == jogador)
            return true;

        return false;
    }

    static bool VerificarEmpate()
    {
        // Verificar se ainda há espaços vazios no tabuleiro
        foreach (var item in tabuleiro)
        {
            if (item == ' ')
                return false;
        }
        return true;
    }
    }

}