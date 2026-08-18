int[] numbers = {5, 4, 6};
for( int i = 0; i < numbers.Length; i++)
{
    int factorial = 1;
    for(int j = 1; j <= numbers[i]; j++)
    {
        factorial *= j;
    }
    numbers[i] = factorial;
}
foreach(int number in numbers)
{
    Console.WriteLine(number);
}