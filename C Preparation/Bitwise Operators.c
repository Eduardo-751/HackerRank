/*
In this challenge, you will use logical bitwise operators. All data is stored in its binary representation. The logical operators, and C language, use  to represent true and  to represent false. The logical operators compare bits in two numbers and return true or false,  or , for each bit compared.

Bitwise AND operator & The output of bitwise AND is 1 if the corresponding bits of two operands is 1. If either bit of an operand is 0, the result of corresponding bit is evaluated to 0. It is denoted by &.

Bitwise OR operator | The output of bitwise OR is 1 if at least one corresponding bit of two operands is 1. It is denoted by |.

Bitwise XOR (exclusive OR) operator ^ The result of bitwise XOR operator is 1 if the corresponding bits of two operands are opposite. It is denoted by .

For example, for integers 3 and 5,

3 = 00000011 (In Binary)
5 = 00000101 (In Binary)

AND operation        OR operation        XOR operation
  00000011             00000011            00000011
& 00000101           | 00000101          ^ 00000101
  ________             ________            ________
  00000001  = 1        00000111  = 7       00000110  = 6

You will be given an integer n, and a threshold, k. Foreach number
from through n, find the maximum valuee of elogical and, or and xor when
compared against all integers through n that are greater than. Consider
avalue only if the comparison returns a resultless than k$. Print the results of the and, 
or and exclusive or comparisons on separate lines, in that order.
*/
#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
//Complete the following function.
void calculate_the_maximum(int n, int k) {
  //Write your code here.
  int maximunAnd=0, maximunOr=0, maximunXor=0;
  for(int i = 1; i<n; i++){
      for(int i2 = i+1; i2<=n; i2++){
          maximunAnd = maximunAnd<(i&i2) && (i&i2)<k ? i&i2 : maximunAnd;
          maximunOr = maximunOr<(i|i2) && (i|i2)<k ? i|i2 : maximunOr;
          maximunXor = maximunXor<(i^i2) && (i^i2)<k ? i^i2 : maximunXor;
      }
  }
  printf("%d\n%d\n%d", maximunAnd, maximunOr, maximunXor);
}

int main() {
    int n, k;
  
    scanf("%d %d", &n, &k);
    calculate_the_maximum(n, k);
 
    return 0;
}