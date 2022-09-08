//Задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пяьтзначное число");
string number = Console.ReadLine()!;
int num = int.Parse(number);
if (num < 10000 || num > 100000)
{
    Console.WriteLine("Вы ввели не пятизначное число!");
}
else if (number.Reverse().SequenceEqual(number))
{
    Console.WriteLine("Число является Палиндром!");
}
else
{
    Console.WriteLine("Число не является полинндромом!");
}


