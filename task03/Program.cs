Console.Write("Введите число N:");
int number = Int32.Parse(Console.ReadLine());
//System.Console.WriteLine(number);

int i = 1;

while (i <= number)
{
    System.Console.WriteLine(i * i * i);
    i = i + 1;
}

System.Console.WriteLine($"Таблица кубов чисел от 1 до {number}");

