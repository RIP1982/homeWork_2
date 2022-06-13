// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

string day1 = "Понедельник";
string day2 = "Вторник";
string day3 = "Среда";
string day4 = "Четверг";
string day5 = "Пятница";
string day6 = "Суббота";
string day7 = "Воскресенье";

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1 || number > 7)
{
    Console.WriteLine("Введенное число не удовлетворяет условию!");
}
else if(number == 1)
{
    Console.WriteLine(day1 + " - рабочий день!");
}
else if(number == 2)
{
    Console.WriteLine(day2 + " - рабочий день!");
}
else if(number == 3)
{
    Console.WriteLine(day3 + " - рабочий день!");
}
else if(number == 4)
{
    Console.WriteLine(day4 + " - рабочий день!");
}
else if(number == 5)
{
    Console.WriteLine(day5 + " - рабочий день!");
}
else if(number == 6)
{
    Console.WriteLine(day6 + " - Ура, выходной!");
}
else if(number == 7)
{
    Console.WriteLine(day7 + " - Ура, выходной!");
}
