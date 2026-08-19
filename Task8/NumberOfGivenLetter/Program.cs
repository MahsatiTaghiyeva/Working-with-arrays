string[] list = {"apple", "banana", "watermelon", "orange"};
char find = 'a';
int count = 0;
foreach(string word in list)
{
    for(int i =0; i < word.Length; i++)
    {
        if(word[i] == find)
        {
            count ++;
        }
    }
}
Console.WriteLine(count);