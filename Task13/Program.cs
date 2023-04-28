Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
int SecondNumber =Number.ToString().Length;
if (SecondNumber >= 3) 
{
	while (Number > 999)
	{
		Number = Number/ 10;
	}
	int result = Number % 10;
	Console.WriteLine("Третья цифра числа -> " + result);
} else {
	Console.WriteLine("Третьей цифры нету,дружок)");
}
