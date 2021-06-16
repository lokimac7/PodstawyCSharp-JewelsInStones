using System;
using System.Linq;

namespace JewelsInStones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Comparison c = new Comparison();
            Console.WriteLine(c.CountJewelInStones("z", "ZZ"));
            Console.WriteLine(c.CountJewelInStones("aA", "aAAbbbb"));
            Console.WriteLine(c.CountJewelsInStonesLinq("z", "ZZ"));
            Console.WriteLine(c.CountJewelsInStonesLinq("aA", "aAAbbbb"));
        }

        public class Comparison
        {
            public int CountJewelInStones(string jewels, string stones)
            {
                int result = 0;
                foreach (var item in stones)
                {
                    foreach (var el in jewels)
                    {
                        if (item == el)
                            result++;
                    }
                }
                return result;
            }

            public int CountJewelsInStonesLinq(string jewels, string stones)
            {
                return stones.Where(x => jewels.Contains(x)).Count();
            }
        }
    }
}
