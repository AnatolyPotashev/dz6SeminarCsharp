// Напишите программу, которая принимает на вход три числа
//  и проверяет, может ли существовать треугольник с сторонами такой длины. (Сумма двух сторон больше третьей)

Console.WriteLine("Enter one number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter two number:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter three number:");
int num3 = Convert.ToInt32(Console.ReadLine());

// int res = 0;
// if (num1 + num2 > num3) res = 1;
// if (num3 + num1 > num2) res = 1;
// if (num2 + num3 > num1) res = 1;

// if (num1 + num2 < num3) res = 0;
// if (num3 + num1 < num2) res = 0;
// if (num2 + num3 < num1) res = 0;

// if (res == 0) Console.WriteLine("Triangle No");
// else Console.WriteLine("Triangle Yes");

// Сделал самостоятельно, знаю, код не технологичен (Много if).
// У группы подсмотрел более оптимальное решение.

if (num1 + num2 > num3 & num3 + num1 > num2 & num2 + num3 > num1)
{
    Console.WriteLine("Triangle Yes");
}
else Console.WriteLine("Triangle No");