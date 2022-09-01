/*
Given an array of integers, calculate the ratios of its elements that are positive, negative, 
and zero. Print the decimal value of each fraction on a new line with  places after the decimal.
Note: This challenge introduces precision problems. The test cases are scaled to six decimal 
places, though answers with absolute error of up to  are acceptable.

*Function Description

Complete the plusMinus function in the editor below.
plusMinus has the following parameter(s):
int arr[n]: an array of integers

*Print

Print the ratios of positive, negative and zero values in the array. Each value should be printed
 on a separate line with 6 digits after the decimal. The function should not return a value.

*Input Format

The first line contains an integer, n, the size of the array.
The second line contains n space-separated integers that describe arr[n].

*Output Format

Print the following  lines, each to  decimals:
proportion of positive values
proportion of negative values
proportion of zeros
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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr, int n)
    {
        float positive = 0;
        float negative = 0;
        float neutral = 0;
        
        foreach(int element in arr){
            if(element>0)
                positive++;
            
            else if(element < 0)
                negative++;
            
            else
                neutral++;
        }
        Console.WriteLine($"{Math.Round(positive/n, 6)}\n{Math.Round(negative/n, 6)}\n{Math.Round(neutral/n, 6)}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr, n);
    }
}