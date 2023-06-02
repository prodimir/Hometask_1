/***********************task_ 19*******************/
// Найти палиндромы среди пятизначных чисел

// Console.Write("Введите целое пятизначное число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int k;
// int i;
// int[] array = new int[5];

// if (x > 0)
// {
//     if ((x > 9999) && (x < 100000)  )
//     {
//         for (i = 4; i >= 0; i--)
//         {
//             array[i] = x % 10;
//             x = x / 10;
//         }
//         if ((array[0] == array[4]) && (array[1] == array[3]) )
//         {
//             Console.WriteLine("Да, это палиндром!");
//         }
//         else
//         {
//             Console.WriteLine("Нет, это не палиндром!");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Вы ввели не пятизначное число! Попробуйте снова.");
//     }
// }
// else 
// {
//     k = -1*x;
//     if ( (k > 9999) && (k < 100000) )
//     {
//         for (i = 4; i >= 0; i--)
//         {
//             array[i] = k % 10;
//             k = k / 10;
//         }
//         if ((array[0] == array[4]) && (array[1] == array[3]) )
//         {
//             Console.WriteLine("Да, это палиндром!");
//         }
//         else
//         {
//             Console.WriteLine("Нет, это не палиндром!");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Вы ввели не пятизначное число! Попробуйте снова.");
//     }
// }



/****************************task_21**************************/
// Расстояние между точками на трехмерной плоскости

// Console.Write("Введите координату x первой точки: ");
// int x_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y первой точки: ");
// int y_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z первой точки: ");
// int z_1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату x второй точки: ");
// int x_2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y второй точки: ");
// int y_2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z второй точки: ");
// int z_2 = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Sqrt(Math.Pow((x_2 - x_1),2) + Math.Pow((y_2 - y_1),2) + Math.Pow((z_2 - z_1),2) );

// Console.WriteLine(distance);

/**************************task_23********************/
// Вводим число N, на выходе получаем список значений кубов от 1 до N

Console.Write("Введите любое целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i;

for (i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i,3) + " ");
}


