Console.WriteLine("Musbet ve cut reqem daxil et: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n%2!=0 || n < 0)
{
    Console.WriteLine("Musbet ve cut reqem daxil et: ");
    n = Convert.ToInt32(Console.ReadLine());
}
n = n*n;
Console.WriteLine(n);