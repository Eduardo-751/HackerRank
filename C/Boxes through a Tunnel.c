/*
You are transporting some boxes through a tunnel, where each box is a parallelepiped, and is characterized by its length, width and height.

The height of the tunnel 41 feet and the width can be assumed to be infinite. A box can be carried through the tunnel only if its height is strictly less than the tunnel's height. Find the volume of each box that can be successfully transported to the other end of the tunnel. Note: Boxes cannot be rotated.

Input Format

The first line contains a single integer n, denoting the number of boxes.
n lines follow with three integers on each separated by single spaces - lenght, width, and height which are length, width and height in feet of the -th box.

Output Format

For every box from the input which has a height lesser than 41 feet, print its volume in a separate line.
*/
struct box
{
	int length, width, height;
};

typedef struct box box;

int get_volume(box b) {
	return (b.length * b.width * b.height);
}

int is_lower_than_max_height(box b) {
	/**
	* Return 1 if the box's height is lower than MAX_HEIGHT and 0 otherwise
	*/
    if(b.height >= 41)
        return 0;
    else 
        return 1;
}

