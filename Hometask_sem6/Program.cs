/////////////////////////////Task_41/////////////////////////////
//Пользователь вводит M чисел. Программа выдает количество чисел больших нуля
Console.Write("Сколько чисел Вы хотите ввести? ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[M];
CreateArray(M);
Abovezero(arr);

void CreateArray(int amountNumbers)
{
    for (int i = 0; i < amountNumbers; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void Abovezero(int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > 0) count++;
    }
    Console.Write($"Чисел больше нуля: {count}");
}







/////////////////////////////Task_43/////////////////////////////
//Программа выдает точку пересечения двух прямых

// Console.Write("Введите точку пересечения с осью ординат 1-ой функции: b1 =  ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите коэффициент пропорциональности 1-ой функции: k1 =  ");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите точку пересечения с осью ординат 2-ой функции: b2 =  ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите коэффициент пропорциональности 2-ой функции: k2 =  ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("_______________ \n");

// IntersectionPoint(b1, k1, b2, k2);

// void IntersectionPoint(double b1, double k1, double b2, double k2)
// {
//     double xCommon = (b2 - b1)/(k1 - k2);
//     double yCommon = k1*xCommon + b1;
//     Console.Write($"Координаты общей точки пересечения: ({xCommon}, {yCommon})");
// }