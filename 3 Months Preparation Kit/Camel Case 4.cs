/*
Camel Case is a naming style common in many programming languages. In Java, method and variable names typically start with a lowercase letter, with all subsequent words starting with a capital letter (example: startThread). Names of classes follow the same pattern, except that they start with a capital letter (example: BlueCar).

Your task is to write a program that creates or splits Camel Case variable, method, and class names.

Input Format

Each line of the input file will begin with an operation (S or C) followed by a semi-colon followed by M, C, or V followed by a semi-colon followed by the words you'll need to operate on.
The operation will either be S (split) or C (combine)
M indicates method, C indicates class, and V indicates variable
In the case of a split operation, the words will be a camel case method, class or variable name that you need to split into a space-delimited list of words starting with a lowercase letter.
In the case of a combine operation, the words will be a space-delimited list of words starting with lowercase letters that you need to combine into the appropriate camel case String. Methods should end with an empty set of parentheses to differentiate them from variable names.
Output Format

For each input line, your program should print either the space-delimited list of words (in the case of a split operation) or the appropriate camel case string (in the case of a combine operation).

Sample Input                    Sample Output

S;M;plasticCup()                plastic cup

C;V;mobile phone                mobilePhone

C;C;coffee machine              CoffeeMachine

S;C;LargeSoftwareBook           large software book

C;M;white sheet of paper        whiteSheetOfPaper()

S;V;pictureFrame                picture frame
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        List<string> input = new List<string>();
        string line;
        while ((line = Console.ReadLine()) != null && line != ""){
            input.Add(line);
        }
        foreach(string item in input){
            camelCase(item);
        }
    }
    
    public static void camelCase(string a){
        string[] myString = a.Split(';');
            string operation = myString[0].Trim();
            string type = myString[1].Trim();
            string input = myString[2].Trim();
            if (operation.Equals("S")){
                switch(type){
                    case "M":
                        SplitMethodAndVariable(input);
                        break;
                    case "C":
                        SplitClass(input);
                        break;
                    case "V":
                        SplitMethodAndVariable(input);
                        break;
                    default:
                        break;
                }
            }
            else{
                switch (type){
                    case "M":
                        CombineMethodAndVariable(input,type);
                        break;
                    case "C":
                        CombineClass(input);
                        break;
                    case "V":
                        CombineMethodAndVariable(input,type);
                        break;
                    default:
                        break;
                }
            }
        }
        
        private static void CombineClass(string input){
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++){
                if(i==0){
                    sb.Append(char.ToUpper(input[i]));
                }
                else if (char.IsWhiteSpace(input[i])){
                    i++;
                    sb.Append(char.ToUpper(input[i]));
                }
                else{
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb.ToString().Trim());
        }

        private static void SplitClass(string input){
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++){    
                if (char.IsUpper(input[i])){
                    sb.Append(" ");
                    sb.Append(input[i]);
                }
                else{
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb.ToString().ToLower().Trim());
        }

        private static void SplitMethodAndVariable(string input){
            int indexOfUpper = 0;
            for (int i=0;i<input.Length-1;i++){
                if(char.IsUpper(input[i])){
                    indexOfUpper = i;
                    break;
                }
            }
            var res = input.Substring(0, indexOfUpper) + " " +input.Substring(indexOfUpper, input.Length- indexOfUpper) ;
            Console.WriteLine(res.Replace("(", "").Replace(")", "").ToLower());
        }

        private static void CombineMethodAndVariable(string input,string type){
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++){
                if (char.IsWhiteSpace(input[i])){
                    i++;
                    sb.Append(char.ToUpper(input[i]));
                }
                else{
                    sb.Append(input[i]);
                }
            }
            if(type.Equals("V")){
                Console.WriteLine(sb.ToString().Trim());
            }
            else{
                sb.Append("(");
                sb.Append(")");
                Console.WriteLine(sb.ToString().Trim());
            }
        }
}
