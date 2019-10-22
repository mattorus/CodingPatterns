using System;
namespace CodingPatterns
{
    public class Helpers
    {
        public Helpers()
        {
        }

        public static void PrintStartFunctionTest(string name)
        {
            Console.WriteLine($"Testing {name}()");
            Console.WriteLine("--------------------------");
        }

        public static void PrintStartTests(string testPattern)
        {
            Console.WriteLine("\n     --------------------------");
            Console.WriteLine($"-------START {testPattern}-------");
            Console.WriteLine("     --------------------------\n");
        }

        public static void PrintEndTests(string testPattern)
        {
            Console.WriteLine("\n     --------------------------");
            Console.WriteLine($"-------END {testPattern}-------");
            Console.WriteLine("     --------------------------\n");
        }

        public static void PrintArray(int[] nums)
        {
            if (nums == null)
            {
                return;
            }

            Console.Write("  [");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                if (i != nums.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
        }
    }
}
