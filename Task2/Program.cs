/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int number = UserInput("Введите целое число: ", "Ошибка ввода!");
Console.WriteLine($"{number} -> {SumFigures(number)}");

int SumFigures(int num1)
{
    int result = 0;
    num1 = Math.Abs(num1);
    do
    {
        int temp = num1 % 10;
        result += temp;
        num1 = num1 / 10;        
    }
    while (num1 != 0);
    return result;
}

int UserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine()??"", out int userNumber)) return userNumber;
        Console.WriteLine(errorMessage);
    }
}