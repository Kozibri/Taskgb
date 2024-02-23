//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void Range(int m, int n)
{
    if (m == n)
    {
        System.Console.WriteLine(m);
        return;
    }

    System.Console.Write(m + "," + " ");
    Range(m + 1, n);

}
int n = 20;
int m = 11;
Range(m, n);