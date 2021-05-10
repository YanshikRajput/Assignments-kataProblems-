using System;
using Two_Joggers;

namespace TwoJoggersProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Positive Integer Values");
            string Value1 = Console.ReadLine();
            int Numb1 = Convert.ToInt32(Value1);

            string val2 = Console.ReadLine();
            int Numb2 = Convert.ToInt32(val2);

            LapsCount obj = new LapsCount();
            int Resultant = obj.Lcm(Numb1, Numb2);
            Console.WriteLine("\n Minimum LapsCount required for both joggers" +
                "before they meet each other again are :");
            Console.WriteLine(Resultant / Numb1);
            Console.WriteLine(Resultant / Numb2);

        }
    }
}
