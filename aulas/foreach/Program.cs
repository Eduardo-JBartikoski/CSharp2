using System.Reflection;



class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[10];
        Random n = new Random();

        for(int i=0; i <nums.Length; i++)
        {
            nums[i] = n.Next(100);
        }
        Array.Sort(nums);

        foreach(int numeros in nums)
        {
            if(numeros % 2 == 0)
            {
            Console.WriteLine($" PAR-{numeros}");
            }
            else{
                Console.WriteLine($"IMPAR- {numeros}");
            }
        }

    }
}
