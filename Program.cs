Console.Clear();

Console.WriteLine("введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

if (number%2 == 0)
{
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}