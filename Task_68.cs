// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int m = inputNumber("Введите m: ");
int n = inputNumber("Введите n: ");


int akker(int m, int n)
{
    if (m == 0) return n + 1;
    else
    if (m > 0 & n == 0) return akker(m - 1, 1);
    else
        return akker(m - 1, akker(m, n - 1));

}

System.Console.WriteLine(akker(m, n));


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