// See https://aka.ms/new-console-template for more information
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a>b)
{
    Console.WriteLine(a);}
    else {
        Console.WriteLine(b);
    }*/



/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if ((a>b) && (a>c)) 
{
    Console.WriteLine(a);}
    else if ((c>a) && (c>b))
{
    Console.WriteLine(c);}
    else if ((b>a) && (b>c)) {
        Console.WriteLine(b);
    } */




/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
if (a%2==0)
{
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
int a=1;

while (a <= n) {
    a += 1;
    if (a%2==1){
        continue;
    }
    Console.WriteLine(a);
}
