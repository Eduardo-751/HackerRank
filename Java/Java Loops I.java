/*
 Objective
In this challenge, we're going to use loops to help us do some simple math.

Task
Given an integer, N, print its first 10 multiples. Each multiple N x i (where 1 <= i <= 10) should be printed on a new line in the form: N x i = result.

Input Format

A single integer, N.

Output Format

Print 10 lines of output; each line i (where 1 <= i <= 10) contains the result of N x i in the form:
N x i = result.
*/
import java.io.*;

class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));

        int N = Integer.parseInt(bufferedReader.readLine().trim());

        bufferedReader.close();
        
        for(int i = 1; i<=10; i++){
            System.out.printf("%d x %d = %d\n", N, i, N*i);
        }
    }
}