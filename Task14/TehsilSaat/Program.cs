Console.WriteLine("Tehsil novunu secin: ");
string tehsil = Convert.ToString(Console.ReadLine());
switch (tehsil)
{
    case "programming":
        Console.WriteLine("400 saat");
        break;
    case "design":
        Console.WriteLine("250 saat");
        break;
    case "system":
        Console.WriteLine("200 saat");
        break;
    default:
        Console.WriteLine("təhsil novu yanlisdir");
        break;

}