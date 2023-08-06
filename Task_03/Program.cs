// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string[] aWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
int ImputNumb(string phrase)
{
    Console.Write(phrase);
    int num = int.Parse(Console.ReadLine()!);

    return num;

}
int num = ImputNumb("Введите число ");
if (num > 0 && num < 8)
{
    if (num == 1)
    {
        Console.WriteLine($" {aWeek[num - 1]} - это рабочий день!");
    }
    if (num == 2)
    {
        Console.WriteLine($" {aWeek[num - 1]} - это рабочий  день!");
    }
    if (num == 3)
    {
        Console.WriteLine($" {aWeek[num - 1]} - это рабочий  день!");
    }
    if (num == 4)
    {
        Console.WriteLine($" {aWeek[num - 1]} - это рабочий  день!");
    }
    if (num == 5)
    {
        Console.WriteLine($" {aWeek[num - 1]} - это рабочий  день!");
    }
    if (num == 6)
    {
        Console.WriteLine($" {aWeek[num - 1]} - это выходной день!");
    }
    if (num == 7)
    {
        Console.WriteLine($" {aWeek[num - 1]} - это выходной день!");
    }
}
else
{
    Console.WriteLine("Такого дня в неделе не существует!");
}
