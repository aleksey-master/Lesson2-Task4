//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void DayWeek(int day)
{
    if (day < 1 || day > 7)
    {
        System.Console.WriteLine("это не день недели");
    }

    else if (day == 6 || day == 7)
    {
        System.Console.WriteLine("это выходной");
    }
    else System.Console.WriteLine("это рабочий день");

}
DayWeek(day);