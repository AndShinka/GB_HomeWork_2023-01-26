// Найти максимальное из трех чисел

int num1 = 99, num2 = 144, num3 = 56;
int MaxOf3 = 0;

if (num1 > num2) MaxOf3 = num1;
else MaxOf3 = num1;

if (num2 > MaxOf3) MaxOf3 = num2;

if (num3 > MaxOf3) MaxOf3 = num3;

Console.WriteLine("Найденное максимальное из трех чисел:" + MaxOf3);
