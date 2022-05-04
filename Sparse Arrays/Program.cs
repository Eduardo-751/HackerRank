/*
There is a collection of input strings and a collection of query strings. For each query string, determine how many times it occurs in the list of input strings. Return an array of the results.

* Example

string = ['ab', 'ab', 'abc']
queries = ['ab', 'abc', 'bc']
There are 2 instances of 'ab', 1 of 'abc' and 0 of 'bc'. For each query, 
add an element to the return array, results = [2, 1, 0].

* Function Description

Complete the function matchingStrings in the editor below. The function must return an array of integers representing the frequency of occurrence of each query string in strings.
matchingStrings has the following parameters:

string strings[n] - an array of strings to search
string queries[q] - an array of query strings

* Returns

int[q]: an array of results for each query

*Input Format

The first line contains and integer n, the size of strings[].
Each of the next n lines contains a string strings[i].
The next line contains q, the size of queries[].
Each of the next q lines contains a string queries[i].
*/
using System.Collections.Generic;
using System.IO;
using System.Text;
using System;

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());
        //List<string> strings = new List<string>();
        var stringMap = new Dictionary<string, int>();        
        for (int i = 0; i < stringsCount; i++)
        {
            string stringsItem = Console.ReadLine();
            if(stringMap.ContainsKey(stringsItem))
                stringMap[stringsItem]++;
            else
                stringMap.Add(stringsItem, 1);
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());
        //List<string> queries = new List<string>();
        var queriesMap = new Dictionary<string, int>();
        var output = new int[queriesCount];
        for (int i = 0; i < queriesCount; i++)
        {
            string queriesItem = Console.ReadLine();
            if(stringMap.ContainsKey(queriesItem))
                output[i] = stringMap[queriesItem];
        }
        
        textWriter.WriteLine(String.Join("\n", output));

        textWriter.Flush();
        textWriter.Close();
    }
}
