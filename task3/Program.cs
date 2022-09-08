// Задача 23: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125
// работает только с положитльными числами.

Console.WriteLine("Введите число");
string number = Console.ReadLine()!;
int num = int.Parse (number);
int[] array = new int[num];

for (int i = 1; i <= num; i++)
{
    array[i - 1] = i * i * i;
}

for (int i = 0; i < num; i++)
{
    Console.Write(array[i]);
    if (i < num - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();
