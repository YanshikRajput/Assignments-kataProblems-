using System;
using System.Collections.Generic;

namespace ConsecutiveSumProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = ConsecutiveSum(new List<int>() { 1, 1, 3, 3, 7, 2, 2, 2, 2 });
            cs.ForEach(i => Console.WriteLine(i.ToString()));
        }
        public static List<int> ConsecutiveSum(List<int> s)
        {
            List<int> res = new List<int>();
            int last = s[0], sum = 0;
            foreach (int i in s)
            {
                if (i == last) sum += last;
                else
                {
                    res.Add(sum);
                    sum = last = i;
                }
            }
            res.Add(sum);
            return res;
        }
    }
    
}
