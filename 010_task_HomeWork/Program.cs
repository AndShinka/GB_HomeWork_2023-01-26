// Выяснить, кратно ли число заданному, если нет, вывести остаток.
//metka:
int num1 = 0;
int num2 = 0;
do
{
   Console.WriteLine("Задайте первое число, на кратность которому будет проверяться второе число: "); 
   num1 = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите второе число (больше! первого), кратность которого первому числу проверяться: "); 
   num2 = Convert.ToInt32(Console.ReadLine());
}
while (num1 > num2);

if (num2 % num1 == 0) Console.WriteLine("Второе число " + num2 + " кратно первому " + num1);

else Console.WriteLine("Второе число " + num2 + " НЕ кратно первому " + num1 + 
                        ", остаток от деления равен: " + (num2 % num1));
//goto metka;