//Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 || number > 999)
{
    Console.WriteLine("Введенное число не соответсвует условию задачи!");
}
int numberWihtoutFirstSymbol = number % 100;
int numberFromSecondPosition = numberWihtoutFirstSymbol / 10;

Console.WriteLine("Вторая цифра из заданного трехзначного числа: " + numberFromSecondPosition);