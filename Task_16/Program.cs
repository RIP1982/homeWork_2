// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();

Console.Write("Введите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if(Square(numberFirst) == numberSecond || Square(numberSecond) == numberFirst)
{
    Console.WriteLine("Является одно число квадратом другого!");
}

else 
{
    Console.WriteLine("Не является одно число квадратом другого!");
}
int Square(int a)
{
    return a*a;
}