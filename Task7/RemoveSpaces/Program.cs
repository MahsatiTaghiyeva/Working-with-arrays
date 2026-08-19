string sentence = "Hello World !";
string newSentence = "";
foreach (char letter in sentence)
{
    if(letter != ' ')
    {
        newSentence += letter;
    }
}
Console.WriteLine(newSentence);
