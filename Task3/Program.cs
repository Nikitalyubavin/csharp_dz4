/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()??"");
int[] arr = new int[n];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++) arr[i] = rand.Next(0, 100);

ShowArray(arr);

void ShowArray(int[] arr)
{
    int index = 0;
    Console.Write("[");
    for (; index < arr.Length - 1; index++) Console.Write($"{arr[index]}, ");
    if (index == arr.Length - 1) Console.Write($"{arr[index]}]");
}
