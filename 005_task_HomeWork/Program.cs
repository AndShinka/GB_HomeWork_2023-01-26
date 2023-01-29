// Показать четные числа от 1 до N
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

Console.WriteLine("Показываю чётные числа  от 1 до " + num + ": ");
while (count <= num)
{
    if (count % 2 == 0) Console.Write(count + "  ");

    count ++;
}


