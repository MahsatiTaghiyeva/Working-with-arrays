string word = "Apple";
bool exists = false;
foreach(char letter in word)
{
    
    
        if(letter == 'A')
        {
            exists = true;
            break;
        }
    
}
if (exists){
    Console.WriteLine("A exists in this string");
}else
    Console.WriteLine("A does not exists");