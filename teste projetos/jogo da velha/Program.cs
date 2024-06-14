namespace jogo_da_velha;

 /* using System;

class JogoDaVelha
{
    static void Main(string[] args)
    {
        // Declaração de variáveis
        char[,] tabuleiro = new char[3, 3];
        char jogadorAtual = 'X';
        bool jogoTerminou = false;

        // Inicialização do tabuleiro
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tabuleiro[i, j] = ' ';
            }
        }

        // Loop do jogo
        while (!jogoTerminou)
        {
            // Exibição do tabuleiro
            ExibirTabuleiro(tabuleiro);

            // Jogada do jogador atual
            Jogar(jogadorAtual, tabuleiro);

            // Verificação de vitória
            if (VerificarVitoria(jogadorAtual, tabuleiro))
            {
                Console.WriteLine("O jogador {0} venceu!", jogadorAtual);
                jogoTerminou = true;
                break;
            }

            // Verificação de empate
            if (EstaEmpatado(tabuleiro))
            {
                Console.WriteLine("Empate!");
                jogoTerminou = true;
                break;
            }

            // Troca de jogador
            jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
        }

        // Exibição do tabuleiro final
        ExibirTabuleiro(tabuleiro);
    }

    static void ExibirTabuleiro(char[,] tabuleiro)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(" {0} ", tabuleiro[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Jogar(char jogador, char[,] tabuleiro)
    {
        int linha, coluna;

        // Leitura da linha
        do
        {
            Console.Write("Digite a linha (1-3): ");
            linha = int.Parse(Console.ReadLine());
        } while (linha < 1 || linha > 3);

        // Leitura da coluna
        do
        {
            Console.Write("Digite a coluna (1-3): ");
            coluna = int.Parse(Console.ReadLine());
        } while (coluna < 1 || coluna > 3);

        // Marcação da posição no tabuleiro
        tabuleiro[linha - 1, coluna - 1] = jogador;
    }

    static bool VerificarVitoria(char jogador, char[,] tabuleiro)
    {
        // Verificação de linhas
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[i, 0] == jogador && tabuleiro[i, 1] == jogador && tabuleiro[i, 2] == jogador)
            {
                return true;
            }
        }

        // Verificação de colunas
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[0, i] == jogador && tabuleiro[1, i] == jogador && tabuleiro[2, i] == jogador)
            {
                return true;
            }
        }

        // Verificação de diagonais
        if (tabuleiro[0, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 2] == jogador)
        {
            return true;
        }

        if (tabuleiro[0, 2] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 0] == jogador)
        {
            return true;
        }

        return false;
    }

    static bool EstaEmpatado(char[,] tabuleiro)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[i, j] == ' ')
                {
                    return false;
                }
            }
        }

        return true;
    }
} */ 
// jogo dois;
using System;

class Program
{
    static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1; // Por padrão, o jogador 1 começa.
    static int choice; // A escolha do jogador para a posição a marcar.
    static int flag = 0; // Verifica quem ganhou.
    static void Main(string[] args)
    {
        do
        {
            Console.Clear(); // Sempre que o loop será novamente o tabuleiro será limpo.
            Console.WriteLine("Jogador 1: X e Jogador 2: O");
            Console.WriteLine("\n");
            if (player % 2 == 0)
            {
                Console.WriteLine("Vez do Jogador 2");
            }
            else
            {
                Console.WriteLine("Vez do Jogador 1");
            }
            Console.WriteLine("\n");
            Board();

            // Verifica se a posição já está marcada.
            bool parseSuccess = Int32.TryParse(Console.ReadLine(), out choice);
            if (arr[choice] != 'X' && arr[choice] != 'O' && parseSuccess)
            {
                if (player % 2 == 0)
                {
                    arr[choice] = 'O';
                    player++;
                }
                else
                {
                    arr[choice] = 'X';
                    player++;
                }
            }
            else
            {
                Console.WriteLine("Desculpe a linha {0} já está marcada com {1}", choice, arr[choice]);
                Console.WriteLine("\n");
                Console.WriteLine("Por favor, espere 2 segundos. O tabuleiro está carregando novamente...");
                System.Threading.Thread.Sleep(2000);
            }
            flag = CheckWin();
        }
        while (flag != 1 && flag != -1);

        Console.Clear();
        Board();

        if (flag == 1)
        {
            Console.WriteLine("Jogador {0} ganhou", (player % 2) + 1);
        }
        else
        {
            Console.WriteLine("Empate");
        }
        Console.ReadLine();
    }
    private static void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
        Console.WriteLine("     |     |      ");
    }
    private static int CheckWin()
    {
        #region Horzontal Winning Condtion
        // Condições de vitória para o jogador 1 ou 2.
        if (arr[1] == arr[2] && arr[2] == arr[3])
        {
            return 1;
        }
        else if (arr[4] == arr[5] && arr[5] == arr[6])
        {
            return 1;
        }
        else if (arr[6] == arr[7] && arr[7] == arr[8])
        {
            return 1;
        }
        #endregion

        #region Vertical Winning Condtion
        else if (arr[1] == arr[4] && arr[4] == arr[7])
        {
            return 1;
        }
        else if (arr[2] == arr[5] && arr[5] == arr[8])
        {
            return 1;
        }
        else if (arr[3] == arr[6] && arr[6] == arr[9])
        {
            return 1;
        }
        #endregion

        #region Diagonal Winning Condition
        else if (arr[1] == arr[5] && arr[5] == arr[9])
        {
            return 1;
        }
        else if (arr[3] == arr[5] && arr[5] == arr[7])
        {
            return 1;
        }
        #endregion

        #region Checking For Draw
        else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
        {
            return -1;
        }
        #endregion

        else
        {
            return 0;
        }
    }
}