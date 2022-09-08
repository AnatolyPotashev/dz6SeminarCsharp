// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter b1 num:");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter k1 num:");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter b2 num:");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter k2 num:");
double k2 = Convert.ToDouble(Console.ReadLine());

// y = k1 * x + b1
// y = k2 * x + b2
// void x()
// {


// }
if (k1 == k2) Console.WriteLine("Прямые параллельны");
else
{

   double y1 = 0;
   double y2 = 0;
y1 = k1*x+b1;
y2 = k2*x+b2;

y1 = k1*x+b1 - y2;
Console.WriteLine(y1);
// Console.WriteLine($"{x1} , {x2}");
}
// Не понимаю как сделать эту работу. Сижу думаю уже второй день, смотрю формулы. Хочу посмотреть решение в следующем семинаре.