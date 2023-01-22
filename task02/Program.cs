int x1 = InputInt("Введите координату X первой точки: ");
int y1 = InputInt("Введите координату Y первой точки:");
int z1 = InputInt("Введите координату Z первой точки:");
int x2 = InputInt("Введите координату X второй точки:");
int y2 = InputInt("Введите координату Y второй точки:");
int z2 = InputInt("Введите координату Z второй точки:");

int InputInt(string message)
{
    System.Console.WriteLine(message + " > ");
    string? inputValue = System.Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int pointX = x2 - x1;
int pointY = y2 - y1;
int pointZ = z2 - z1;

double l = Math.Sqrt(pointX * pointX + pointY * pointY + pointZ * pointZ);
System.Console.WriteLine(l);