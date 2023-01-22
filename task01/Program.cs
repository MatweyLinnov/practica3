Console.Write("Введите 5 - ти значное число:");
int number = Int32.Parse(Console.ReadLine());
//System.Console.WriteLine(number);

string name = Convert.ToString(number);
int l = name.Length;
//System.Console.WriteLine(l);

if (l == 5)
{
    if (name[0] == name[4] && name[1] == name[3])
    {
        System.Console.WriteLine($"{number} - является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"{number} - не является палиндромом");
    }
}
else
{
    System.Console.WriteLine($"{number} - не 5 - ти значное число");
}