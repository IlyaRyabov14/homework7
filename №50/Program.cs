Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine()??"");
Console.Write("Введите номер столбца: ");
int columns = int.Parse(Console.ReadLine()??"");

int [,] Array = new int[5, 10]; 
 
void Fullarray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
Fullarray(Array);
PrintArray(Array);
if (row < Array.GetLength(0) && columns < Array.GetLength(1)) Console.WriteLine(Array[row, columns]);
else Console.WriteLine($"{row} {columns} -> такого числа в массиве нет");
