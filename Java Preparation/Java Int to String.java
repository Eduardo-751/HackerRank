
/*
You are given an integer N, you have to convert it into a string.

Please complete the partially completed code in the editor. If your code successfully converts N into a string S the code will print "Good job". Otherwise it will print "Wrong answer".

N can range between -100 to 100 inclusive.

Input Format

100

Output Format

Good job
*/
class Solution {

    public static void main(String[] args) {
        int n = 100;
        String stringValue = Integer.toString(n);

        if (stringValue != null) {
            System.out.println("Good job");
        } else {
            System.out.println("Wrong answer");
        }
    }
}