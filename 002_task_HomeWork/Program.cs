// По заданному номеру дня недели вывести его название
string Day1 = "Понедельник", Day2 = "Вторник", Day3 = "Среда",
     Day4 = "Четверг", Day5 = "Пятница", Day6 = "Суббота", Day7 = "Воскресенье";

int DayNum = 0;

do
{
   Console.WriteLine("Введите номер дня недели в диапазоне от 1 до 7: "); 
   DayNum = Convert.ToInt16(Console.ReadLine());
}
while ((DayNum < 1) | (DayNum >7));

if (DayNum == 1)  Console.WriteLine("Введеному номеру "+ DayNum +" соответствует день недели " + Day1);
if (DayNum == 2)  Console.WriteLine("Введеному номеру "+ DayNum +" соответствует день недели " + Day2);
if (DayNum == 3)  Console.WriteLine("Введеному номеру "+ DayNum +" соответствует день недели " + Day3);
if (DayNum == 4)  Console.WriteLine("Введеному номеру "+ DayNum +" соответствует день недели " + Day4);
if (DayNum == 5)  Console.WriteLine("Введеному номеру "+ DayNum +" соответствует день недели " + Day5);
if (DayNum == 6)  Console.WriteLine("Введеному номеру "+ DayNum +" соответствует день недели " + Day6);
if (DayNum == 7)  Console.WriteLine("Введеному номеру "+ DayNum +" соответствует день недели " + Day7);
