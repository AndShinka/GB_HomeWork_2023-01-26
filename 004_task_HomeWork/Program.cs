// Выяснить является ли число чётным

Console.WriteLine("Ведите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2! == 0) Console.WriteLine("Число: " + num + " ЧЁТНОЕ");

else Console.WriteLine("Число: " + num + " НЕ ЯВЛЯЕТСЯ ЧЁТНЫМ");