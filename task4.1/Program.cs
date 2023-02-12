/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B. Не использовать Math.Pow

3, 5 -> 243 (3⁵)

2, 4 -> 16 */
int Prompt(string massage)
{
    System.Console.Write($"{massage}: ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int a = Prompt("Введите число A");
int b = Prompt("Введите число B");

int Degree(int b)
{
    int Prod = a;
    for (int i = 2; i <= b; i++)
    {
        Prod = Prod * a;
    }
    return Prod;
}
int fakt = Degree(b);
System.Console.WriteLine($"число {a} в степени {b} равно {fakt}");

