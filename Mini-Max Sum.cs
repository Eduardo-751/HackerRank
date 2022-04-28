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
