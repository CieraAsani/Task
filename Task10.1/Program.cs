// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначеное число");
int Number = Convert.ToInt32(Console.ReadLine());
int ThirNumber = Number.ToString().Length;
if (ThirNumber == 3) 
{
	int result = ( Number/10 ) % 10;
	Console.WriteLine("Второе число -> " + result);
} 
else 
{
	Console.WriteLine("Это не трехзначаное число");
}