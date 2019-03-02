using System;

namespace PRand
{
    class Program
    {
        static void Main(string[] args)
        {
            SemiRand rn;
            int[] arr;
            
            int max = 10;
            arr = new int[] {1, 2, 5, 7};
            rn = new SemiRand();

            string joinedArray = string.Join(",", arr);
            Console.WriteLine($"Your random number: {rn.NextInt(max, arr)}\nShould not be in:\n[{joinedArray}]");
        }
    }
}
