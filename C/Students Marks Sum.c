/*
You are given an array of integers, marks, denoting the marks scored by students in a class.

The alternating elements marks0, marks2, marks4 and so on denote the marks of boys.
Similarly, marks1, marks3, marks5 and so on denote the marks of girls.
The array name, , works as a pointer which stores the base address of that array. In other words, marks contains the address where marks0 is stored in the memory.

For example, let  and  stores 0x7fff9575c05f. Then, 0x7fff9575c05f is the memory address of .

Function Description

Complete the function, marks_summation in the editor below.

marks_summation has the following parameters:

int marks[number_of_students]: the marks for each student
int number_of_students: the size of marks[]
char gender: either 'g' or 'b'

Returns

int: the sum of marks for boys if gender = b, or of marks of girls if gender = g
*/

//Complete the following function.
int marks_summation(int* marks, int number_of_students, char gender) {
  //Write your code here.
  int sum = 0;
  if(gender == 'b'){
        for(int i = 0; i<number_of_students; i++){
            if(i%2 == 0)
                sum += *(marks+i);
        }
  }
  else{
        for(int i = 0; i<number_of_students; i++){
            if(i%2 == 1)
                sum += *(marks+i);
        }
  }
  return sum;
}
