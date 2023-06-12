//////////////////////////task_47//////////////////////////
//Задать двумерный массив mxn
// Console.Write("Укажите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int pos_neg;
// double[,] array = new double[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         pos_neg = new Random().Next(0,2);
//         if (pos_neg == 0)
//         {
//             array[i, j] = new Random().NextDouble() * -20;
//             Console.Write(array[i, j] + " ");
//         }
//         else
//         {
//             array[i, j] = new Random().NextDouble() * 20;
//             Console.Write(array[i, j] + " ");
//         }
        
//     }
//     Console.WriteLine();
    
// }


//////////////////////////task_50//////////////////////////
// Ввести адрес ячейки. Программа выдает число в ячейке или уведомление о его отсутствии

// Console.Write("Введите номер строки: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int j = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int m = new Random().Next(1,11);
// int n = new Random().Next(1,11);

// Console.WriteLine($"строки: {m}; столбцы: {n}");
// Console.WriteLine();

// int[,] arr = new int[m, n];

// FillArray(arr);
// PrintElement(arr);

// void FillArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(-10,11);
//         Console.Write(array[i, j] + " ");             
//     }
//     Console.WriteLine();
    
// }
// }

// void PrintElement(int[,] array)
// {
//     Console.WriteLine("_______________");

//     if ((i >= m) || (j >= n)) Console.Write("Такого элемента в массиве нет!");
    
//     else Console.Write(array[i, j]);
// }

//////////////////////////task_52//////////////////////////
//Задать двумерный массив mxn. Найти среднее арифметическое каждого столбца

Console.Write("Укажите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

FillArray(arr);
AverageColumn(arr);

void FillArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-10,11);
        Console.Write(array[i, j] + " ");             
    }
    Console.WriteLine();
    
}
}

void AverageColumn(int[,] array)
{
    Console.Write($"Среднее арифметическое столбцов: ");
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double mean = 0;
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];   
        }
        mean = (double) sum/array.GetLength(0);
        Console.Write(mean + "; ");
    }
    
}