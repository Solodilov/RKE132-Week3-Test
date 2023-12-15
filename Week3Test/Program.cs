Console.WriteLine("Mis hinda sa sai?");
string userMark = Console.ReadLine().ToLower();

if (userMark == "a")
{
    Console.WriteLine("Suurepärane!");
}
else if (userMark == "b")
{
    Console.WriteLine("Väga hea!");
}
else if (userMark == "c")
{
    Console.WriteLine("Hea!");
}
else if (userMark == "d")
{
    Console.WriteLine("Rahuldav");
}
else if (userMark == "e")
{
    Console.WriteLine("Kasin");
}
else if (userMark == "f")
{
    Console.WriteLine("Puudulik");
}
else
{
    Console.Write("Vale väärtus");
}