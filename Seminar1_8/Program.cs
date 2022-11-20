//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int a = 2;
if (a==N|N==0)
{
    Console.WriteLine($"{N}");
}
if (N>a)
{  while (a<=N)
    {Console.Write($"{a} ");
     a = a+2;
    }
}
if (N<a)
{   a = -2;
    while (a>=N)
    {Console.Write($"{a} ");
     a = a-2;
    }
}
if (N==1)
{
    Console.WriteLine("В заданном диапазоне чётные числа отсутствуют");
}
if (N==-1)
{
    Console.WriteLine("0");
}