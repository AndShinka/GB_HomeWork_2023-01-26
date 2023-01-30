// Найти третью цифру числа или сообщить, что её нет
//metka:

int num = 0;
Console.WriteLine("Введите число для эксперимента: "); 
num = Convert.ToInt32(Console.ReadLine());

if (num / 100 > 0) Console.WriteLine("Третьей цифрой числа " + num + " является цифра: " + (num / 100 % 10));
else Console.WriteLine("У числа " + num + " нет третьей цифры. ");

Console.WriteLine();
//goto metka;
