// Показать вторую цифру трёхзначного числа

int num = 0;

do
{
   Console.WriteLine("Введите трёзначное число в диапазоне от 100 до 999: "); 
   num = Convert.ToInt32(Console.ReadLine());
}
while ((num < 100) | (num >999));

int lastDigit = (num / 10 %10);

Console.WriteLine("В трехзначном числе " + num + ",  вторая цифра: " + lastDigit);
