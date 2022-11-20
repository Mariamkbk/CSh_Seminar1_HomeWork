// напишите программу которая принимает на ввод число любой разрядности и на выходе показывает 
//третью цифру этого числа слева направо

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n<0)
{
    n = n * (-1);
}
while (n>999)
{
    n = n/10;
}
if (n<99)
{
    Console.WriteLine("Третья цифра отсутствует");
}
else
{
    Console.WriteLine(n%10);  
}
