/*
Maria plays college basketball and wants to go pro. Each season she maintains a record of her 
play. She tabulates the number of times she breaks her season record for most points and 
least points in a game. Points scored in the first game establish her record for the season, 
and she begins counting from there.

* Example

score = [12, 24, 10, 24]
Scores are in the same order as the games played. She tabulates her results as follows:

                                     Count
    Game  Score  Minimum  Maximum   Min Max
     0      12     12       12       0   0
     1      24     12       24       0   1
     2      10     10       24       1   1
     3      24     10       24       1   1
Given the scores for a season, determine the number of times Maria breaks her records for most and least points scored during the season.

* Function Description

Complete the breakingRecords function in the editor below.

breakingRecords has the following parameter(s):

int scores[n]: points scored per game

* Returns

int[2]: An array with the numbers of times she broke her records. Index 0 is for breaking most points records, and index 1 is for breaking least points records.

* Input Format

The first line contains an integer , the number of games.
The second line contains n space-separated integers describing the respective values of
score[0], score[1], ..., score[n-1]
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

    public static int[] breakingRecords(List<int> scores){

        int min = scores[0];
        int max = scores[0];
        int[] breakTheRecord = new int[2]{0, 0};
        foreach(int i in scores){
            if(i > max){
                breakTheRecord[0]++;
                max = i;
            }
            if(i < min){
                breakTheRecord[1]++;
                min = i;
            }
        }
        return breakTheRecord;
    }

}

class Solution{

    public static void Main(string[] args){
        
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        int[] result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
