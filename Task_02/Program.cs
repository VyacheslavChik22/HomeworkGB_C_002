// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int ImputNumb(string phrase)
// {
//     Console.Write(phrase);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// int num = ImputNumb("Введите любое число ");

// int ThirdDigit(int num)
// {
//     while (num > 999)
//     {
//         num /= 10;
//     }
//     return num % 10;
// }

// bool test(int num)
// {
//     if (num < 100)
//         return false;
//     else return true;
// }

// if (test(num) != true)
//     Console.WriteLine($"{num} Третьей цифры нет");
// else
//     Console.WriteLine($"Третьей цифрой числа {num} является {ThirdDigit(num)}");


int EnterDigit(string phrase)
{
    Console.Write(phrase);
    return int.Parse(Console.ReadLine()!);
}

int firstNum = EnterDigit("Введите число: ");

int number = firstNum;
System.Console.WriteLine(number);

void ThirdDigit(int number)
{
    int result = 0;
    if (number > 100)
    {
        while (true)
        {
            result = number / 100 % 10;
            Console.WriteLine($"В числе {number} третья цифра {result}");
            break;
        }
    }
    else
    {
        Console.WriteLine("Третей цифры в этом числе здесь нет!");
    }
}

ThirdDigit(number);
