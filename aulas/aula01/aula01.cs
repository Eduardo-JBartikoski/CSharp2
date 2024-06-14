using System;
class Principal{
    static void Main(){
        int [] n= new int [5];
        Random num = new Random();
        for (int i=0;i<n.Length;i++){
            n[i] = num.Next(50);
            Console.WriteLine(n[i]);
        } 
       /* int[] vetor1 =new int[5];
   Random random = new Random();
    
    for(int i=0; i<vetor1.Length;i++){
      vetor1[i] = random.Next(50);
      Array.Sort(vetor1);
      Console.WriteLine(vetor1[i]);
      } */
    }
}