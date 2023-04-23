//  Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number >= 100&&Number<=999)
{
    int LastNumber = Number % 10;
Console.WriteLine($"Последния цифра числа {Number} => {LastNumber}");
}
else Console.WriteLine ("Некорретный ввод!");