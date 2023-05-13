// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.



int num = inputNumber("Введите число от которого будем отсчет: ");

Console.Write(counter(num));

int counter(int num)
{
    
    if (num != 1) 
    {
        Console.Write($"{num}, ");
        return counter(num - 1);
    }
    else return 1; 
}

int inputNumber(string message)
{
    int number;
    string text;

    while (true)
    {
        Console.Write(message);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}