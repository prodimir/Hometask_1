 ///////////////Task_10////////////////////////
 
//  Console.Write("Введите трехзначное число: ");
//  int x = Convert.ToInt32(Console.ReadLine());
//  if ((x < 99) || (x > 999))
//  {
//     Console.WriteLine("Вы ввели не трехзначное число! Попробуйте снова.");
//  }
//  else
//  {
//     int first_number = x % 100;
//     int second_number =  first_number / 10;
//     Console.WriteLine(second_number);
//  }

/**************************Task_13***************************/
// Console.Write("Введите любое число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y;
// if (x < 100)
//  {
//     Console.WriteLine("Третьей цифры нет! Попробуйте снова.");
//  }
//   else
//  {
//       while(!(x < 1000))
//    {
//          x = x / 10;
//    }
//    y = x % 10;
//    Console.WriteLine(y);
//  }
 
 /**************************Task_15************************/
Console.Write("Введите число от 1 до 7: ");
int x = Convert.ToInt32(Console.ReadLine());
if ((x < 1) || (x > 7))
{
   Console.Write("Вы ввели неподходящее число! Попробуйте снова. ");
}
else
{
   if ((x == 6) || (x == 7))
   {
      Console.Write("Да!");
   }
   else 
   {
      Console.Write("Нет.");
   }
}