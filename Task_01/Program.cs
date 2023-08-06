// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ImputNumb(string phrase)
{
    Console.Write(phrase);
    int num = int.Parse(Console.ReadLine()!);

    return num;

}

int num = ImputNumb("Введите трехзначное число ");

if ((num / 100 > 0) && (num / 1000 == 0))
{
    num = num / 10;
    int secondDigit = num % 10;
    Console.WriteLine($"Вторая цифра в веденом числе: {secondDigit}");
}
else
{
    Console.WriteLine("Ваше число не трехзначное, попробуйте ещё раз!");
}
