/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (без пеобразования типов)

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int getSecond(int num)
// {
//   if(num<100 || num>999) {
//        Console.WriteLine($"Внимание! Число {num} не треъхзначное.");
//      return -1;
//    }
//   else {
//       int second = num/10%10
//      return second;
//     }
// }



/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (без пеобразования типов) */

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int GetThirdDigit(int k)
// {
//     if (k<100) return -1;
//     while (k >= 1000) k /= 10;
//     int d = k % 10;
//     return d;
// }

// void PrintThirdDigit(int num)
// {
//     int res = GetThirdDigit(num);
//     if (res < 0)
//         Console.WriteLine($"Число {num} не имеет 3й цифры");
//     else
//         Console.WriteLine($"3я чифра в числе {num}: {res}");
// }

// Console.Write("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// PrintThirdDigit(num);

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели для проверки на выходной: ");
int num = Convert.ToInt32(Console.ReadLine());
CheckWeekend(num);

void CheckWeekend(int num)
{
    if(num>0 && num<8)
    {
        if(num>5)
            Console.WriteLine("выходной");
        else 
            Console.WriteLine("не выходной");
    }
    else
    {
            Console.WriteLine("Такого дня недели не существует");
    }
}

