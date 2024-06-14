namespace contains;

class Program
{
    static void Main(string[] args)
    {
       string texto = "Esta é uma frase de exemplo que contém várias palavras.";
       string[] palavras = texto.Split(' ');
       string[] letrasA = new string[palavras.Length];
       int indice = 0;
       foreach(string palavra in palavras)
       {
        if(palavra.Contains('a') || palavra.Contains('A'))
        {
            
            letrasA[indice]= palavra;
            indice++;
        }
       }
        
        for (int i = 0; i < indice; i++)
        {
            Console.Write(letrasA[i] + " ");
        }
    }
}
