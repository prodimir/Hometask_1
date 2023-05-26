/************************Task_2**************************
Console.Write("Введите первое число: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double y = Convert.ToDouble(Console.ReadLine());

if(y > x)
{
   Console.WriteLine($"{y} = max");
}
else
{
   Console.WriteLine($"{x} = max");
}
*/
/************************Task_4**************************
Console.Write("Введите первое число: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double z = Convert.ToDouble(Console.ReadLine());
if((y > x) && (y > z) )
{
    Console.WriteLine($"{y} = max");
}
else
{
    if(z > x)
        {
            Console.WriteLine($"{z} = max");
        }
    else
        {
            Console.WriteLine($"{x} = max");
        }   
}*/

/************************Task_6**************************
Console.Write("Введите любое целое число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x % 2 == 0)
    {
        Console.Write($"{x} четное");
    }
else
    {
        Console.Write($"{x} нечетное");
    }
*/

/************************Task_8**************************/
Console.Write("Введите любое целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N)
    {
        if(i % 2 == 0)
            {
                Console.Write(i+" ");
            }
        i++;
    }
