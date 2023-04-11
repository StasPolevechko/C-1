Console.Write("введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write("введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";

int userNamber1 = int.Parse(userInput1);
int userNamber2 = int.Parse(userInput2);
if (userNamber1 == userNamber2 * userNamber2)
{
    Console.WriteLine($"a={userNamber1}, b={userInput2} -> да");
}
else
{
    Console.WriteLine($"a={userNamber1}, b={userInput2} -> нет");
};