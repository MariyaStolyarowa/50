//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
void FillArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(-100, 100);
        }
}
void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($" {Array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}   
Console.Clear();
Console.Write("Введите индекс строки массива от 0 до 9 = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца массива от 0 до 9 = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Array1= new int[10,10];
FillArray(Array1);
PrintArray(Array1);
if (m >= Array1.GetLength(0)|| n >= Array1.GetLength(1))
{
    Console.Write($"Элемента массива c инексами [{m},{n}] не существует");
}
else
{
    Console.WriteLine($"Элемент на позиции [{m},{n}] = {Array1[m,n]} ");
}

