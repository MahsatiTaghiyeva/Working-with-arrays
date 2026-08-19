int[] numbers =  {7, 12, 5, 8};
int[] newnumbers = new int[4];
int min = numbers[0];
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]< min)
    {
        min = numbers[i];
    }
}
int index = 0;
foreach(int number in numbers)
{
    
    if(number == min)
    {
        continue;
    }
    newnumbers[index] = number;
    index++;
    
}
foreach(int number in newnumbers)
{
    Console.WriteLine(number);
}