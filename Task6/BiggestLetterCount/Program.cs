﻿string word = "kertenkele";
int max = 0;
char l = ' ';
foreach(char letter in word){
    int count = 0;
   
    for(int i = 0; i < word.Length; i++)
        {
            if(letter == word[i])
                {
                count++;
                }
        }
        if(count > max)
            {
                max = count;
                l = letter;                
            }
    }
    Console.WriteLine(max);
    Console.WriteLine(l);