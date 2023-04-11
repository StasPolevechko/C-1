Console.Write("введите номер дня недели: ");
string userInput = Console.ReadLine() ?? "";
int userNamber = int.Parse(userInput);

if (userNamber == 1)
{
    Console.WriteLine($"a={userNamber} -> понедельник");
}
else if (userNamber == 2)
{
    Console.WriteLine($"a={userNamber} -> вторник");
}
else if (userNamber == 3)
{
    Console.WriteLine($"a={userNamber} -> среда");
}
else if (userNamber == 4)
{
    Console.WriteLine($"a={userNamber} -> четверг");
}
else if (userNamber == 5)
{
    Console.WriteLine($"a={userNamber} -> пятница");
}
else if (userNamber == 6)
{
    Console.WriteLine($"a={userNamber} -> суббота");
}
else if (userNamber == 7)
{
    Console.WriteLine($"a={userNamber} -> воскресенье");
}
else
{
    Console.WriteLine("нет такого дня недели");
}