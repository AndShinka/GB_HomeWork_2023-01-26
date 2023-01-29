// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Ведите первое число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());

if (Num2 == Num1 * Num1)
{
    Console.WriteLine("Первое число " + Num1 + " ЯВЛЯЕТСЯ квадратом числа " + Num2);
}
else
{
Console.WriteLine("Первое число " + Num1 + " НЕ является квадратом числа " + Num2);
}