
/*
Problem: Given an int array, find all possible subsets i.e O(2^n)

Approach:
[1,2]

1. start with an empty set {}
2. we May add 1 or not : {} ; {1} 
3. foreach of the above case we may add 2 or not: {2} , {}; {1,2}, {1}
4. Since no more elements, so print all the stacked up subsets.

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace allSubsetsGame
{
    public class Allsubsets
    {
        public static void Main(string[] args)
        {
            Nullable<int>[] arr={1,2,3,4,5,6,7,8,9};//using nullable type
            all_subsets(arr);
        }
        
        public static void all_subsets(Nullable<int>[] arr){
            Nullable<int>[] subset=new Nullable<int>[arr.Length]; //subset=[null, null]
            helper(arr, subset, 0);
        }
        
        public static void helper(Nullable<int>[] arr, Nullable<int>[] subset, int i){
            if(i==arr.Length)
                printset(subset);
            else{
            subset[i]=null;
                helper(arr, subset, i+1);
            subset[i]=arr[i];
                helper(arr, subset, i+1);
            
            }
        }
        
        public static void printset(Nullable<int>[] subset){
            Console.WriteLine("[{0}]",string.Join(" ", subset));
        }
    }
}