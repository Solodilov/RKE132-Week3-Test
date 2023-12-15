Console.WriteLine("Mis hinda sa sai?");
string userMark = Console.ReadLine().ToLower();

switch (userMark)
{
    case "a":
        Console.WriteLine("Suurepärane!");
            break;
    case "b":
        Console.WriteLine("Väga hea!");
        break;
    case "c":
        Console.WriteLine("Hea!");
        break;
    case "d":
        Console.WriteLine("Rahuldav");
        break;
    case "e":
        Console.WriteLine("Kasin");
        break;
    case "f":
        Console.WriteLine("Puudulik");
        break;
    default:
        Console.WriteLine("Vale väärtus");
        break;
}
