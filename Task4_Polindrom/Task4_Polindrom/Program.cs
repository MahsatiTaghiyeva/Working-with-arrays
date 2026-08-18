int n = 121;
int m = 2553;
for(int i = n; i< m; i++)
{
    int num = i; //121

    int reversed = 0 ;
    while (num > 0)
    {
        int digit = num % 10;  //1 2 1
        reversed = reversed*10 + digit; //1 12 121
        num/= 10; //12 1 0

    }
    if(reversed == i)
    {
        Console.WriteLine(i);
    }
}