﻿/*int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int [] array = {11, 23, 656, 232, 323, 2223, 23, 22, 222 };

int result = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(result);*/

int [] array = {13, 452, 673, 47, 235, 676, 127, 348, 673};

int n = array.Length;

int find = 673;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }

 index++;   
}
