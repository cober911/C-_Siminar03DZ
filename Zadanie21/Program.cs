/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintData(string value1, double value2)
{
    Console.WriteLine(value1 + value2);
}

double FindLen(int x1, int y1, int z1, int x2, int y2, int z2)
{    // Получаю корень из квадратов кординат точек.
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                   Math.Pow((y2 - y1), 2) +
                   Math.Pow((z2 - z1), 2));
}

//Запрашиваю кординаты в трёх плоскостях.
int x1 = ReadData("Введите координату X первой точки: ");
int y1 = ReadData("Введите координату y второй точки: ");
int z1 = ReadData("Введите координату z третей точки: ");
int x2 = ReadData("Введите координату X третей точки: ");
int y2 = ReadData("Введите координату y четвертой точки: ");
int z2 = ReadData("Введите координату y пятой точки: ");
//Вывожу кординаты
double result = FindLen(x1, y1, z1, x2, y2, z2);
result = Math.Round(result, 2); //Сокращаем остаток после запятой до двух цифр.
PrintData("Расстояние между точками: ", result);