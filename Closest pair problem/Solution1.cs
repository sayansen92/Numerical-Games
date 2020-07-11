//Given Problem is find the two closest pairs of numbers from two arrays to a target sum
//a1 = [-1, 3, 8, 2, 9, 5]
//a2 = [4, 1, 2, 10, 5, 20]
//target = 24

/*
//Algorithm:
Step 1: Find max value out of two arrays with Time complexity O(n)
Step 2: Save the max result
Step 3: Save the pointer to the other array than the one where max was found because this is the array where we will need to find the other element of the pair
Step 4: Find the diff between target value and max, i.e, the closest value we need to find now
Step 5: Initialize the tolerance as 0, i.e if above closest value is not found then we have to tolerate some +- to the diff
Step 6: For N no. of pairs, repeat steps 7 to 9:
	Step 7: Foreach of the elements of the pointed array:
		Step 8: If current element matches to diff value, Print the pair Else check the next element
Step 9: If required number of pairs have been found break; Else update the tolerance by 1 value.

# closest_sum_pair(a1, a2, target) should return (5, 20) or (3, 20).
*/



using System;


namespace ClosestPairToSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            try {
                int[] arr1 = { -1, 3, 8, 2, 9, 5};
                int[] arr2 = { 4, 1, 2, 10, 5, 20};
                int total = 24;
                int pairs = 2;
                if (arr1.Length == arr2.Length && pairs <= arr1.Length)
                    find(arr1, arr2, total, pairs);
                else
                    throw new Exception("Arr lengths don't match or no.of pairs are more than Arr length");
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
        public static void find(int[] arr1, int[] arr2, int total, int pairs)
        {
            int max = 0; //maximum number out of two arrays
            int[] arr_pt = null; //pointer to an array
            //Search in arr1
            foreach (int a in arr1)//O(n)
                if (a > max)
                {
                    max = a;
                    arr_pt = arr2;
                }
            //Search in arr2
            foreach (int a in arr2)//O(n)
                if (a > max)
                {
                    max = a;
                    arr_pt = arr1;
                }

            //ultimate max is 20 in case 1
            //Now we need to find the closest difference between target value and max

            int diff = total - max;//diff=4
            //Keep searching for closest pair
            int tolerance = 0;

            while (pairs > 0)
            {
                //foreach of the elements in the array find if the diff value is present
                foreach (int a in arr_pt)//O(n)
                {
                    if (a == diff + tolerance || a == diff - tolerance)
                    {
                        Console.WriteLine("{0},{1}", max, a);
                        --pairs;
                        break;
                    }
                }
                tolerance++; //if diff value is not present increase tolerance // settle for next closest diff value
            }
        }
    }
}
