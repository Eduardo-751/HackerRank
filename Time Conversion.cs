using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result{

    public static string timeConversion(string s){
        DateTime d = DateTime.Parse(s);
        return d.ToString("HH:mm:ss");
    }

}

class Solution{

    public static void Main(string[] args){
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

