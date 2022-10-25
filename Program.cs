// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Сколько чисел ввести?: ");
double n = Convert.Todouble32(Console.ReadLine());
double[] array = new double[n];

double Kol = 0;
for (double i = 0; i < array.Length; i++)
{
    array[i] = Convert.Todouble32(Console.ReadLine());

    if (array[i] > 0)
    Kol = Kol + 1 ;    
}
Console.Write($"Колличество чисел больше ноля: {Kol }");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Введите число К1: ");
double к1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число B1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число К2: ");
double к2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число B2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (к1 - к2);
double y = к1 * x + b1;

Console.WriteLine($"Точка пересечения: ({x};{y}) ");








