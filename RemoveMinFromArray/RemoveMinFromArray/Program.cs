using System.Globalization;

int[] numbers =  {7, 12, 5, 8};
int min = numbers[0];
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]< min)
    {
        min = numbers[i];
    }
}
foreach(int number in numbers)
{
    if(number == min)
    {
        continue;
    }
    Console.WriteLine(number);
}