// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите через пробел несколько строк");
string Str = Console.ReadLine();
string[] arrStr = Str.Split(' ');

for (int i = 0; i < arrStr.Length; i++)
{
    if (arrStr[i].Length <= 3)
        Console.WriteLine(arrStr[i]);
}
