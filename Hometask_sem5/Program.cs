/*************************task_34***************************/
////////////////////////////////////////////////////////////////////////
// Создать массив со случайными трехзначными числами. Вывести количество четных чисел
////////////////////////////////////////////////////////////////////////

// int i;
// int j = 0;
// int[] Array = new int[10];
// Console.Write("[");
// NewArray();
// Console.Write("]");
// find_even_numbers();
// Console.Write($" -> {j}");


// void find_even_numbers()
// {
//     for (i = 0; i < Array.Length; i++)
//     {
//         if (Array[i] % 2 == 0)
//         {
//             j++;
//         }
//         else
//         {

//         }
//     }
// }

// void NewArray()
// {
//     for (i = 0; i < Array.Length - 1; i++)
//     {
//         Array[i] = new Random().Next(100,1000);
//         Console.Write(Array[i] + ", ");
//     }
//     Array[9] = new Random().Next(100,1000);
// }

/*************************task_36***************************/
//////////////////////////////////////////////////////////////////////////////////////////////
// Создать массив со случайными числами. Вывести сумму элементов, стоящих на нечетных позициях
//////////////////////////////////////////////////////////////////////////////////////////////

// Console.Write("Укажите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// int sum = 0;

// Console.Write("[");
// new_array();
// Console.Write("] -> ");

// sum_odd_number();
// Console.Write(sum);

// void new_array()
// {
//     for (int i = 0; i < N; i++)
//     {
//         array[i] = new Random().Next(-20,21);
//         Console.Write(array[i] + " ");
//     }
// }

// void sum_odd_number()
// {
//     for (int j = 0; j < N; j++)
//     {
//         if (j % 2 == 0)
//         {

//         }
//         else 
//         {
//             sum+=array[j];
//         }
//     }
// }

/*************************task_38***************************/
//////////////////////////////////////////////////////////////////////////////////////////////
// Создать массив вещественных чисел. Найти разность максимального и минимального значений.
//////////////////////////////////////////////////////////////////////////////////////////////

Console.Write("Укажите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];
int j = 0;
double max = 0;
double min;

Console.Write("[");
new_array();
Console.Write("] -> \n");
max_min();
differense();

void new_array()
{
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().NextDouble()*-20;// можно домножить и на +20, чтобы были положительные числа. Не знаю, как сделать так,
        // чтобы на рандоме выдавались и отрицательные, и положительные вещественные числа.
        Console.Write(array[i] + " ");
    }
}

void max_min()
{
    max = array[0];
    min = array[0];
    j++;
    while (j < N)
    {
        if (array[j] > max)
        {
            max = array[j];
        }
        else if (array[j] < min)
        {
            min = array[j];
        }
        j++; 
            
    }
    Console.WriteLine($"\n max: {max} \n min: {min} \n");
}

void differense()
{
    Console.WriteLine($"Разность max и min: {Math.Abs(max - min)} \n");
}