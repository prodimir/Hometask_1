///////////////task_64/////////////////////////
// Вывод натуральных чисел от N до 1
///////////////////////////////////////////////

// Console.Write("Введите любое натуральное число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(PrintNumbers(N));

// string PrintNumbers(int num1)
// {
//     if(num1 == 1)
//     {
//         return num1.ToString();
//     }
//     return(num1 +" "+ PrintNumbers(num1-1));
// }


///////////////task_66/////////////////////////
// Вывод натуральных чисел от N до 1
///////////////////////////////////////////////
// Console.Write("Укажите нижний предел числового диапазона: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите верхний предел числового диапазона: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.Write(Sum(M,N));

// int Sum(int limit1, int limit2)
// {
//     int value = 0;
//     if (limit1 == limit2)
//     {
//         return value += limit1;
//     }
    
//     return value = limit1 + Sum(limit1 + 1, limit2);
// }

////////////////task_68/////////////////////
//Описать функцию Аккермана
///////////////////////////////////////////
//Рожа Петер: A(0,m) = m + 1; A(n+1,0) = A(n,1); A(n+1,m+1) = A(n,A(n+1,m))

Console.Write("Укажите первый аргумент n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите второй аргумент m: ");
int m = Convert.ToInt32(Console.ReadLine());
int A = 0;


Console.Write(Akkerman(n,m));

int Akkerman(int n, int m)
{

    if (m == 0)
    {
        return A = Akkerman(n - 1, m = 1);
    }
    else if (n == 0)
    {
        return A = 1 + m;
    }
    return A = Akkerman(n-1,Akkerman(n,m-1));
}