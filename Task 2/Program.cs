//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

static int Ak(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if (m == 0)
        return Ak(n - 1, 1);
    else
        return Ak(n - 1, Ak(n, m - 1));
}

System.Console.WriteLine(Ak(2, 3));
