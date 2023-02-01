// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите размер массива (натуральное число): ");
int n = Convert.ToInt32(Console.ReadLine());
double[] Create(int size, double min, double max)
{
double[] arr = new double[size];
for (int i = 0; i < size; i++)
{
 Console.WriteLine("Введите вещественное число от 1 до 100: ");
 arr[i] = Convert.ToDouble(Console.ReadLine());
}
return arr;
}

void PrintArray (double[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
else Console.Write($"{arr[i]}");
}
Console.Write("]");
}

double[] array = Create(n, 1, 100);
PrintArray(array);


double Max(double[] arr)
{
double max = arr[0];
for (int i = 1; i < arr.Length; i++)
{
if(arr[i] > max) max = arr[i];
}
return max;
}
double maximum = Max(array);
// Console.WriteLine(maximum);

double Min(double[] arr)
{
double min = arr[0];
for (int i = 1; i < arr.Length; i++)
{
if(arr[i] < min) min = arr[i];
}
return min;
}
double minimum = Min(array);
double result = maximum - minimum;
double dResult = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($" -> {dResult}");