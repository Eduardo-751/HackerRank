/*
Print a pattern of numbers from 1 to n as shown below. Each of the numbers is separated by a single space.

                            4 4 4 4 4 4 4  
                            4 3 3 3 3 3 4   
                            4 3 2 2 2 3 4   
                            4 3 2 1 2 3 4   
                            4 3 2 2 2 3 4   
                            4 3 3 3 3 3 4   
                            4 4 4 4 4 4 4   

* nput Format

The input will contain a single integer n.
*/
#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() 
{

    int n;
    scanf("%d", &n);
  	// Complete the code to print the pattern.4
      
    int size = (n*2)-1;

        for(int i=0; i<size; i++){
            for(int j=0; j<size; j++){
                int min = i<j? i:j;
                min=min<size-i? min:size-i-1;
                min=min<size-j? min:size-j-1;
                printf("%d ", n-min);
            }
            printf("\n");
        } 
    return 0;
}