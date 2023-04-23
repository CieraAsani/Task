// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine ("Введите целое число ");
int number  = int.Parse(Console.ReadLine()); // "7" -> 7
// - 2 147 483 648 ... 2 147 483 647
int square = number * number;
Console.WriteLine($"квардрат числа {number} = {square}");
