// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// void CheckPal(int num)
// {
//     int num1 = num / 10000;
//     int num2 = num % 10;
//     int num3 = num / 1000 % 10;
//     int num4 = num / 10 % 10;
//     if (num1 == num2 && num3 == num4)
//         Console.WriteLine("Это палиндром");
//     else 
//         Console.WriteLine("Это не палиндром");
// }

// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// CheckPal(num);




// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// void FindKoord(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     int resX = (x2 - x1) * (x2 - x1);
//     int resY = (y2 - y1) * (y2 - y1);
//     int resZ = (z2 - z1) * (z2 - z1);
//     double res = Math.Sqrt(resX + resY + resZ);
//     Console.WriteLine(res);
// }

// Console.WriteLine("Введите координату X1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z1");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату X2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z2");
// int z2 = Convert.ToInt32(Console.ReadLine());

// FindKoord(x1, x2, y1, y2, z1, z2);




// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// void PrintCube(int num)
// {
//     int count = 1;
//     string res = $"{num} -> ";

//     while(count <= num)
//     {
//         int tmp = count*count*count;
//         count++;
//         res += $"{tmp}, ";
//     }
//     Console.WriteLine(res);
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// PrintCube(num);