/*
Objective
This challenge will help you learn the concept of recursion.

A function that calls itself is known as a recursive function. The C programming language supports recursion. But while using recursion, one needs to be careful to define an exit condition from the function, otherwise it will go into an infinite loop.

To prevent infinite recursion, if...else statement (or similar approach) can be used where one branch makes the recursive call and other doesn't.

void recurse() {
    .....
    recurse()  //recursive call
    .....
}
int main() {
    .....
    recurse(); //function call
    .....
}

Input Format

The first line contains a single integer, .

The next line contains 3 space-separated integers, a, b, and c.

Output Format

Print the nth term of the series, S(n).
*/
#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
//Complete the following function.
int find_nth_term(int n, int a, int b, int c) {
  //Write your code here.
  for(int i=3; i<n; i++){
      int aux = a+b+c;
      a = b;
      b = c;
      c = aux;
  }
  return c;
}

int main() {
    int n, a, b, c;
  
    scanf("%d %d %d %d", &n, &a, &b, &c);
    int ans = find_nth_term(n, a, b, c);
 
    printf("%d", ans); 
    return 0;
}