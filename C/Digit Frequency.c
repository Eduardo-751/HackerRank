/*
Given a string, s, consisting of alphabets and digits, find the frequency of each digit in the given string.

Input Format

The first line contains a string, num which is the given number.

Constraints


All the elements of num are made of english alphabets and digits.

Output Format

Print ten space-separated integers in a single line denoting the frequency of each digit from 0 to 9.
*/
#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
#include <ctype.h>

int main() {
    char str[1000];
    int numbers[10] = {0,0,0,0,0,0,0,0,0,0};
    scanf("%[^\n]%*c", str);
    for(int i=0; i<strlen(str); i++){
        if(isdigit(str[i])){
            numbers[str[i] - 48]++;
        }
    }
    for(int i=0; i<10; i++){
        printf("%d ", numbers[i]);
    }
    return 0;
}