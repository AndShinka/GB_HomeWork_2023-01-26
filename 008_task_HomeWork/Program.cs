// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int num = 0;

do
{
   Console.WriteLine("Введите двуначное число в диапазоне от 10 до 99: "); 
   num = Convert.ToInt32(Console.ReadLine());
}
while ((num < 10) | (num >99));

int firstDigit = (num / 10 %10);
int lastDigit = (num %10);

Console.WriteLine("В двузначном числе " + num + ",  первая цифра: " + firstDigit+ ",  вторая цифра: " + lastDigit);

if (firstDigit > lastDigit) Console.WriteLine("В двузначном числе " + num + ",  наибольшая цифра: " + firstDigit);
else Console.WriteLine("В двузначном числе " + num + ",  наибольшая цифра: " + lastDigit);


