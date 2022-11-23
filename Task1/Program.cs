/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

double number1 = UserInput("Введите первое число: ", "Ошибка ввода!");
double number2 = UserInput("Введите второе число: ", "Ошибка ввода!");
Console.WriteLine($"{number1}, {number2} -> {NumberInGrade(number1, number2)}");

double NumberInGrade(double num1, double num2)
{
    double result = Math.Pow(num1, num2);
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