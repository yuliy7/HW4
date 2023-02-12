/* Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

int Prompt(string massage)
{
    System.Console.Write($"{massage}: ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] CreateArray(int X)
{
    int[] array = new int[X];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]};");
    }

}

int X = Prompt("Размер массива: ");
int[] array = CreateArray(X);
ShowArray(array);


