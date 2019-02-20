using System;

namespace RandomMax
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Generate a list of 100 random integers between 0 and 1000 and ouput the maximum value.
            int[] numList = new int[100];

            Random rnd = new Random();
            int max = 0;
            for (int count = 0; count < 100; count++)
            {
                numList[count] = rnd.Next(0,1000);
                //Console.WriteLine(numList[count]);
                if (numList[count] > max)
                    max = numList[count];
            }
            
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
