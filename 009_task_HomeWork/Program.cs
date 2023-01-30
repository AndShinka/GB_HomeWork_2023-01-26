// Удалить вторую цифру трёхзначного числа

int num = 0;

do
{
   Console.WriteLine("Введите трёзначное число в диапазоне от 100 до 999: "); 
   num = Convert.ToInt32(Console.ReadLine());
}
while ((num < 100) | (num >999));

int firstDigit = (num / 100 %10);
int lastDigit = (num %10);

Console.WriteLine("В трехзначном числе " + num +
                     ",  первая цифра: " + firstDigit +
                     ",  третья цифра: " + lastDigit);

Console.WriteLine("Трехзначное число " + num +
                     ",  без второй цифры можно изобразить так: " + firstDigit + "_" + lastDigit 
                     + ", или так: " + (firstDigit * 10 + lastDigit));

