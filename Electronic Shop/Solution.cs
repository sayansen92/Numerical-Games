using System;
using System.Linq;

namespace Electronic_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                int n = Int32.Parse(input.Split(" ")[1]);
                int m = Int32.Parse(input.Split(" ")[2]);
                int S = Int32.Parse(input.Split(" ")[0]);
                /*
                 1000>=n,m>=1
                 10^6>=S>=1 
                 */
                if (!Enumerable.Range(1, 1000).Contains(n) || !Enumerable.Range(1, 1000).Contains(m) || !Enumerable.Range(1, 1000000).Contains(S))
                    throw new Exception("Check range of inputs");
                input = Console.ReadLine();
                int[] keyboard_prices = Array.ConvertAll(input.Split(" "), Int32.Parse);
                /*
                Array.ForEach(keyboard_prices, item=> {
                    Console.Write("{0} ",item);
                });
                */
                Console.WriteLine();
                input = Console.ReadLine();
                int[] usb_prices = Array.ConvertAll(input.Split(" "), Int32.Parse);

                /*
                 10 2 3
                 keyboard= 3 1
                 USB= 5 2 8
                 */
                Console.WriteLine(find(keyboard_prices, usb_prices, S));
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            
        }

        public static int find(int[] arr1, int[] arr2, int total)
        {
            

            //Console.WriteLine(String.Join(" ",arr1));
            //Console.WriteLine(String.Join(" ", arr2));

            //Take 1st element from 2nd arr and get max valued pair with 1st arr
            int max = -1, temp=0, x=0, y=0;
            //O(n^2)
            foreach (int i in arr2)//max first
            {
                foreach (int j in arr1)//min first
                {
                    temp = (i + j);
                    
                    if(temp>max&&temp<=total)
                    {
                        max = temp;
                        x = i;
                        y = j;
                    }
                }
            }

                 
            
            //Console.WriteLine("Final->{0},{1}={2}", x, y, max);
            return max;
        }
    }
}

//tested input sets:
/*
 20 5 5
7 8 9 13 11
17 18 9 3 2


 */
