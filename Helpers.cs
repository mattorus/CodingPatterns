using System;
namespace CodingPatterns
{
    public class Helpers
    {
        public Helpers()
        {
        }

        public static void PrintStartTests(string testPattern)
        {
            Console.WriteLine("\n     --------------------------");
            Console.WriteLine($"-------{testPattern} START-------");
            Console.WriteLine("     --------------------------\n");
        }

        public static void PrintEndTests(string testPattern)
        {
            Console.WriteLine("\n     --------------------------");
            Console.WriteLine($"-------{testPattern} END-------");
            Console.WriteLine("     --------------------------\n");
        }

        public static void PrintArray(int[] nums)
        {
            Console.Write("  [");
            foreach (int n in nums)
            {
                Console.Write(n);
                if (n != nums[nums.Length - 1])
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
        }
    }
}
