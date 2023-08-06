int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 50;
int b1 = 1000;
int c1 = 60;
int a2 = 780;
int b2 = 670;
int c2 = 9870;
int a3 = 980;
int b3 = 500;
int c3 = 980;

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));


Console.WriteLine(max);
