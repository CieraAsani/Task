// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> не

Console.WriteLine("Введите число дня недели");
int NumberDay = Convert.ToInt32(Console.ReadLine());
if (NumberDay >= 1 && NumberDay <=7) {
	if (NumberDay >= 6) 
    {
		Console.Write("Это выходной,Ура Ура");
	} else {
		Console.Write("Рабочий день,опять идти на работу:( ");
	}
} else {
	Console.Write("Введите чесло от 1 до 7");
}