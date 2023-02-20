// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом. Через строку решать нельзя.

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int res1 = num / 10000 %;
int res2 = num % 10;

// int res1 = num / 10000;
// int res2 = num % 10;

// if(res1 == res2)
// {
//     int res3 = num / 1000;
//     int res4 = num % 100;
//     if(res3 == res4)
//         Console.WriteLine("Да, это палиндром");
//     else
//         Console.WriteLine("Нет, это не палиндром");
// }
// else
//     Console.WriteLine("Нет, это не палиндром");





// while(count <= 3)
// {
//     int res1 = num % 1000;
//     int res2 = num % 10;
//     count++;
//     if(res1 == res2)
//         Console.WriteLine($"{num} -> да ");
//     else
//         Console.WriteLine($"{num} -> нет");
// }
