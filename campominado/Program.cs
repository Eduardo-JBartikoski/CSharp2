using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq.Expressions;

namespace campominado
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] campo = new int[10, 10];
            int[,] jogo = new int[10, 10];
            bool vitoria = false;

            int qtdLinhas = campo.GetLength(0);
            int qtdColunas = campo.GetLength(1);

            //salvando dados
            bool problemaArquivo = false;
            string caminho_absoluto = "C:\\Users\\Reverse\\Documents\\C#\\campominado\\campo.txt";
            
                try{
                    StreamReader sr = new StreamReader(caminho_absoluto);
                    string linha_arq = sr.ReadLine();
                    int linha_mtz = 0;
                    int coluna_mtz = 0;
                        while(linha_arq != null || linha_mtz<10){
                            foreach(var numero in linha_arq.Split(',')){
                                int num;
                                if(int.TryParse(numero, out num)){
                                    campo[linha_mtz, coluna_mtz] = num;
                                    jogo[linha_mtz, coluna_mtz] = -1;
                                    coluna_mtz++;
                                }
                            }
                    linha_arq = sr.ReadLine();
                    coluna_mtz = 0;
                    linha_mtz++;
                        }
                    sr.Close();
                }
                catch(Exception e){
                    Console.WriteLine("Ocorreu um problema na leitura do arquivo!");
                    problemaArquivo = true;
                }




            for (int l = 0; l < qtdLinhas; l++)
            {
                for (int c = 0; c < qtdColunas; c++)
                {
                    campo[l, c] = 0;
                    jogo[l, c] = -1;
                }
            }

            //posicionamento bandeiras
            Random gerador = new Random();
            int linha = gerador.Next(qtdLinhas);
            int coluna = gerador.Next(qtdColunas);
            campo[linha, coluna] = 2;

            //posicionamento bombas
            int bombasPosicionadas = 0;
            do
            {
                linha = gerador.Next(qtdLinhas);
                coluna = gerador.Next(qtdColunas);

                if (campo[linha, coluna] == 0)
                {
                    campo[linha, coluna] = 1;
                    bombasPosicionadas++;
                }
            } while (bombasPosicionadas < 5);

            bool fimJogo = false;
            do
            {
                for (int l = 0; l < qtdLinhas; l++)
                {
                    for (int c = 0; c < qtdColunas; c++)
                    {
                        Console.Write(string.Format("{0,-3}", jogo[l, c]));
                    }
                    Console.WriteLine();

                }
                Console.Write("Selecione uma linha [1-10]: ");
                linha = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Selecione uma coluna [1-10]: ");
                coluna = Convert.ToInt32(Console.ReadLine()) - 1;

                switch (campo[linha, coluna])
                {
                    case 0:
                        jogo[linha, coluna] = 0;
                        Console.Write("Continue tentando. \n\n");
                        break;
                    case 1:
                        for (int l = 0; l < qtdLinhas; l++)
                            {
                                for (int c = 0; c < qtdColunas; c++)
                                {
                                    if (campo[l, c] == 1)
                                        jogo[l, c] = 1; // Mostrar as bombas
                                }
                            }
                            fimJogo = true;
                            Console.WriteLine("BOOOM. Você perdeu \n\n");
                            break;
                    default:
                        jogo[linha, coluna] = 2;
                        Console.Write("Parabéns. Você ganhou!\n\n");
                        fimJogo = true;
                        vitoria = true;
                        break;
                }
            } while (!fimJogo);
            
            string[] arquivo = File.ReadAllLines(caminho_absoluto);
            string msgVitorias = arquivo[arquivo.Length - 2];
            string msgDerrotas = arquivo[arquivo.Length - 1];
            
            try 
                {
                    StreamWriter sw = new StreamWriter(caminho_absoluto);
                    int contagem;
                    int linha_sobrescrever;
                    string texto;
                    
                    if(vitoria)
                    {
                        int.TryParse(msgVitorias.Split(':')[1], out contagem);
                        linha_sobrescrever = 11;
                        texto = "Vitórias:";
                    } 
                    else 
                    {
                        int.TryParse(msgDerrotas.Split(':')[1], out contagem);
                        linha_sobrescrever = 12;
                        texto = "Derrotas:";
                    }
                    contagem++;
                    for(int i = 0; i < arquivo.Length; i++)
                    {
                        if(i == linha_sobrescrever)
                        {
                            sw.WriteLine(texto + contagem);
                        } 
                        else 
                        {
                            sw.WriteLine(arquivo[i]);
                        }
                    }
                    sw.Close(); // Fechar o StreamWriter após o loop for
                } 
                catch (Exception e) 
                {
                Console.WriteLine("Ocorreu um problema na escrita do arquivo!");
                }
            }
        }
    }


    
    

