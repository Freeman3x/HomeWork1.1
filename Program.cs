//Задание 1
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num2 > num1)
{
Console.WriteLine($"Наибольшее число {num2}");
}
else
{
    Console.WriteLine($"Наибольшее число {num1}");
}
*/

//Задание 2
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max =num1;
if(num1 > max) max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;
Console.WriteLine($"Наибольшее число {max}");
*/

//Задание 3
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0)
{
Console.WriteLine("Число является четным");
}
else
{
Console.WriteLine("Число является не четным");
}
*/

//Задание 4
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int numA = 1;
while(numN >= numA)
{
    if(numA % 2 == 0)
    {
        Console.Write($"{numA} ");
    }
    numA++;
}
*/