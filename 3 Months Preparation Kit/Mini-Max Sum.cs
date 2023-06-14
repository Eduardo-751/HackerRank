/*
Given five positive integers, find the minimum and maximum values that can be calculated
 by summing exactly four of the five integers. Then print the respective minimum and maximum 
 values as a single line of two space-separated long integers.

*Example

arr = [1, 3, 5, 7, 9]
The minimum sum is 1 + 3 + 5 + 7 = 16 and 
the maximum sum is 3 + 5 + 7 + 9 = 24. 

The function prints
16 24

* Function Description

Complete the miniMaxSum function in the editor below.
miniMaxSum has the following parameter(s):
arr: an array of 5 integers

* Print

Print two space-separated integers on one line: the minimum sum and the maximum sum of 4 of 5 elements.

* Input Format

A single line of five space-separated integers.
Constraints
1 <= arr[i] <= 10^9

* Output Format

Print two space-separated long integers denoting the respective minimum and maximum 
values that can be calculated by summing exactly four of the five integers. 
(The output can be greater than a 32 bit integer.)

*/
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result{

    public static void miniMaxSum(List<long> arr){
        
        arr.Sort();
        long Sum = 0;
        foreach(long i in arr){
            Sum += i;
        }
        long minValue = Sum - arr.Max();
        long maxValue = Sum - arr.Min();

        Console.WriteLine(minValue + " " + maxValue);
    }

}

class Solution{

    public static void Main(string[] args){

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
