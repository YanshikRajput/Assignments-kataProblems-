using System;

namespace ProductAndLcm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Arr = new int[,] { { 15, 18 }, { 4, 5 }, { 12, 60 } };
            int m = Arr.GetLength(0);
            int lcm = 0, x, y;
            int n = Arr.GetLength(1);
            int[] Arr_product = new int[m];
            int[] arr_lcm = new int[m];
            int sum = 0;
            int product = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    product *= Arr[i, j];
                }

                Arr_product[i] = product;
                product = 1;
            }

            for (int i = 0; i < m; i++)
            {
                int k = 0;



                x = Arr[i, k];
                y = Arr[i, k + 1];
                while (Arr[i, k] != Arr[i, k + 1])
                {
                    if (Arr[i, k] > Arr[i, k + 1])
                    {
                        Arr[i, k] = Arr[i, k] - Arr[i, k + 1];
                    }
                    else
                    {
                        Arr[i, k + 1] = Arr[i, k + 1] - Arr[i, k];
                    }
                }
                lcm = (x * y) / Arr[i, k];
                arr_lcm[i] = lcm;
            }

            for (int i = 0; i < m; i++)
            {
                sum += Arr_product[i] - arr_lcm[i];
            }
            Console.WriteLine(sum);
        }


    }
    
}
