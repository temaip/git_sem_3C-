// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Console.WriteLine("Ввод пятизначного числа");
// int x = Convert.ToInt32(Console.ReadLine());
// int x1 = x / 10000;
// int x2 = x / 1000 % 10;
// int x4 = x / 10 % 10;
// int x5 = x % 10;
// if (x1 == x5 && x2 == x4)
// {
//     Console.WriteLine("Число является палиндромом");
// }
// else
// {
//     Console.WriteLine("Число неявляется палиндромом");
// }


// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double SystemCoor( int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
// }
// Console.WriteLine ("Введите число x1");
// int Ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число y1");
// int Ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число z1");
// int Az = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число x2");
// int Bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число y2");
// int By = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число z2");
// int Bz = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine( Math.Round(SystemCoor(Ax, Ay, Az, Bx, By, Bz) ,2));


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write(N + " -> ");

// if (N >= 0)
// {
//     for (int i = 0; i <= N; i++)
//     Console.Write(i * i * i + " ");
// }
// else
// {
//     if (N < 0)
//     {
//         for (int i = 1; i >= N; i--)
//         Console.WriteLine( i * i * i + " ");
    
//     }
// }