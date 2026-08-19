int num1 = 34;
int num2 =23;
Console.WriteLine("Simvolu daxil et: ");
char operation = Convert.ToChar(Console.ReadLine());
while(operation != '+' && operation != '-' && operation != '*' && operation != '/'){
Console.WriteLine("Enter Valid sign! Simvolu daxil et: ");
operation = Convert.ToChar(Console.ReadLine());}
switch (operation)
{
    case '+':
        Console.WriteLine(num1+num2);
        break;
    case '-':
        Console.WriteLine(num1-num2);
        break;
    case '*':
        Console.WriteLine(num1*num2);
        break;
    case '/':
        Console.WriteLine(num1/num2);
        break;
}
