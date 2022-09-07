// Напишите программу, которая будет преобразовывать десятичное число в двоичное

// Console.WriteLine("Press Enter number:");
// int num = Convert.ToInt32(Console.ReadLine());

// Convert.ToString(num, 2);
// Console.WriteLine(num);

// Console.WriteLine("Enter number:");
//      int i = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Convert.ToString(i, 2).PadLeft(8, '0'));

// Использовал гугл, искал коды, не понимаю как сделать самостоятельно и без подсказок.
// Как понял ToString(i, 2) возводит в двоичную систему, а PadLeft(8, '0') задаёт "Циферблат" из 8 нулей, 
// на котором и будет отображаться результат.

// Решение автора задачи:
int number = int.Parse(Console.ReadLine());

string res1 = Convert.ToString(number, 2);
string res2 = DecToNum(number, 2);

Console.WriteLine($"{number}->{res1}");

// Универсальный математический для перевода из 10 в любую
string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        int ost = decNumber / otherSystem;
        res = nums[decNumber - otherSystem * ost] + res;
        decNumber /= otherSystem;
    }
    return res;
}