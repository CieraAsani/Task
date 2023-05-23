// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] newArr = CreateArray(8);
Console.Write("[");
PrintArray(newArr);
Console.Write("]");

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
if(i < array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}");
}

}

void FillArray(int[] array)
{
var rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(0, 33);
}
}
int[] CreateArray(int size)
{
int[] array = new int[size];
var rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(0, 33);
}
return array;
}
