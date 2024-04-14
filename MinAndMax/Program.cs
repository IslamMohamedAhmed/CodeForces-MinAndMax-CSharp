using static System.Console;
using static System.Convert;
using static System.Math;


int n, mx = 0, mn = 100005 ;
int[] arr1 = new int[100005];
n = ToInt32(ReadLine());
string str1 = ReadLine();
var arr2 = str1.Split(" ");
for(int i = 0; i < n; i++)
{
    arr1[i] = ToInt32(arr2[i]);
    mn = Min(mn, arr1[i]);
    mx = Max(mx, arr1[i]);
}

WriteLine($"{mn} {mx}");

