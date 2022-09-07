// Напишите программу, которая будет преобразовывать десятичное число в двоичное

// Console.WriteLine("Press Enter number:");
// int num = Convert.ToInt32(Console.ReadLine());

// Convert.ToString(num, 2);
// Console.WriteLine(num);

Console.WriteLine("Enter number:");
int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(i, 2).PadLeft(8, '0'));

            // Использовал гугл, искал коды, не понимаю как сделать самостоятельно и без подсказок.
            // Как понял ToString(i, 2) возводит в двоичную систему, а PadLeft(8, '0') задаёт "Циферблат" из 8 нулей, 
            // на котором и будет отображаться результат.