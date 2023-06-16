/*********************task_54*****************/
//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
///////////////////////////////////////////////////////////////////////////
// Console.Write("Укажите количество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите количество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[row,column];

// FillArray(arr);
// SortRow(arr);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            array[i,j] = new Random().Next(-10,11);
//            Console.Write(array[i,j] + " "); 
//         }
//         Console.WriteLine();
//     }
// }

// void SortRow(int[,] array)
// {
    
//     int maxrow;
//     int j;
//     int temp;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int k = 0; k < array.GetLength(1); k++)
//         {

//             maxrow = array[i,k];

//             for (j = k + 1; j < array.GetLength(1); j++)
//             {
                
//                 if (array[i,j] > maxrow)
//                 {
//                     temp = maxrow;
//                     maxrow = array[i,j];
//                     array[i,j] = temp;

//                 }
//             }
//             array[i,k] = maxrow;
            
//         }
        
//     }
//     PrintArray(array);
// }

// void PrintArray(int[,] array)
// {
//     Console.WriteLine("_____________");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
/////////////////////////////////////////////////////////////////////////

/*********************task_56*****************/
//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// прямоугольный массив - означает массив, размерностью больше 1.
///////////////////////////////////////////////////////////////////////////

// Console.Write("Укажите количество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите количество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[row,column];

// FillArray(arr);
// SumRow(arr);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            array[i,j] = new Random().Next(-10,11);
//            Console.Write(array[i,j] + " "); 
//         }
//         Console.WriteLine();
//     }
// }

// void SumRow(int[,] array)

// {
//     int[] collectSum = new int[row];
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {   
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i,j];
//         }
//         collectSum[i] = sum;
//     }
//     MinRowSum(collectSum);
// }

// void MinRowSum(int[] array)
// {
//     int minRowIndex = 1;
//     int minSum = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < minSum)
//         {
//             minSum = array[i];
//             minRowIndex = i + 1;
//         }
//     }
//     Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex}");
// }
/////////////////////////////////////////////////////////////////////////

/*********************task_58*****************/
//Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
///////////////////////////////////////////////////////////////////////////

// // Матрица 1
// Console.Write("Укажите количество строк 1-ой матрицы: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите количество столбцов 1-ой матрицы: ");
// int column1 = Convert.ToInt32(Console.ReadLine());

// // Матрица 2
// Console.Write("Укажите количество строк 2-ой матрицы: ");
// int row2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите количество столбцов 2-ой матрицы: ");
// int column2 = Convert.ToInt32(Console.ReadLine());

// int[,] mtrx1 = new int[row1,column1];
// int[,] mtrx2 = new int[row2,column2];

// FillArray(mtrx1);
// FillArray(mtrx2);
// MatrixMultipliaction(mtrx1,mtrx2);

// void FillArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            matrix[i,j] = new Random().Next(-10,11);
//            Console.Write(matrix[i,j] + " "); 
//         }
//         Console.WriteLine();
//     }
    
// }

// void MatrixMultipliaction(int [,] matrix1, int[,] matrix2)
// {
//     Console.WriteLine("___________ \n Result:");
//     int[,] mtrxResult = new int[row1,column2];
//     if (!(row2 == column1))
//     {
//         Console.WriteLine("Операция невозможна!");
//     }
//     else
//     {
//         for (int i = 0; i < matrix1.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix2.GetLength(1); j++)
//             {
//                 for (int k = 0; k < matrix1.GetLength(1); k++)
//                 {
//                   mtrxResult[i,j] += matrix1[i,k]*matrix2[k,j];
//                 }
//                 Console.Write(mtrxResult[i,j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

/////////////////////////////////////////////////////////////////////////

/*********************task_60*****************/

//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
/////////////////////////////////////////////////////////////////////////

// Console.Write("Укажите количество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите количество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите размер массивов в элементах матрицы: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[, ,] mtrx = new int[row,column,size];
// int[] repeat = new int[90];
// int check;

// FillMatrix(mtrx);

// void FillMatrix(int[,,] matrix)
// {
//     for (int i = 0; i < mtrx.GetLength(0); i++)
//     {
//         for (int j = 0; j < mtrx.GetLength(1); j++)
//         {
//             for (int k = 0; k < mtrx.GetLength(2); k++)
//             {
//                 mtrx[i,j,k] = new Random().Next(10,100);
//                 check = mtrx[i,j,k];
//                 RandomNumber(check);
//                 mtrx[i,j,k] = check;
//                 Console.Write($"{mtrx[i,j,k]}({i},{j},{k})" + " ");

//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// void RandomNumber(int parametr)
// {
    
//     for (int i = 0; i < repeat.Length; i++)
//     {
              
//         if (repeat[i] == parametr)
//         {
//             parametr = new Random().Next(10,100);
//             RandomNumber(parametr);
//         }
//         else
//         {
            
//             if ((repeat[i] >= 10) || (repeat[i] <= 100))
//             {
                
//             }
//             else
//             {
//                 repeat[i] = parametr;
//                 break;
                
//             }

           
//         }
        
//     }
// }

/////////////////////////////////////////////////////////////////////////

/*********************task_62*****************/

//Напишите программу, которая заполнит спирально массив 4 на 4.
/////////////////////////////////////////////////////////////////////////

// int[,] array = new int[4,4];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int i = 0; i < length; i++)
//     {
        
//     }
// }