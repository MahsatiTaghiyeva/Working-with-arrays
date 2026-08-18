string word = "kertenkele";
foreach(char letter in word){
    int count = 0;
    for(int i = 0; i < word.Length; i++)
        {
            if(letter == word[i])
                {
                count++;
                }
        }
        if(count == 1)
            {
                Console.WriteLine(letter);
                break;
            }
    }
    