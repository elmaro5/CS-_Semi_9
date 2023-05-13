// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int m = inputNumber("Введите m: ");
int n = inputNumber("Введите n: ");


int summ = 0;
Console.WriteLine(counter(m, n));
int counter(int m, int n)
{
    if (m != n) return summ += m + counter(m + 1, n);
    else return m;
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