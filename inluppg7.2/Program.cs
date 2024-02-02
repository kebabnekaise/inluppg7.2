using System;

namespace inluppg7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> talList = new List<int>();
            talList.Add(123);
            talList.Add(13);
            talList.Add(99);
            talList.Add(12);

            Console.WriteLine(Maximum(talList));
        }

        static int Maximum(List<int> list)
        {
            return list.Max();
        }
    }
}