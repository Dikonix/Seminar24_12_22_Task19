Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();
if (number is not null)
{
    if (number.Length == 5)
    {
        if ((number[0] == number[4]) && (number[1] == number[3]))
        {
            Console.WriteLine($"{number} - палиндром");
        }
        else
        {
            Console.WriteLine($"{number} - не палиндром");
        }
    }
    else
    {
        Console.WriteLine("Введено некорректное значение");
    }
}