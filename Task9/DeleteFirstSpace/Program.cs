string sentence = "   salam necesen?   ";
string newSentence = "";
bool check = false;
for(int i = 0; i < sentence.Length; i++)
{
    if(sentence[i] != ' ')
    {
        check = true;
    }
    if (check)
    {
        newSentence += sentence[i];
    }
    
    
}

Console.WriteLine(newSentence);