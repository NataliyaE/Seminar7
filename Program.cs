// Прога, которая на вход принимает позиции элемента. и выдает его значение, либо инфу, что элемента нет

Console.WriteLine("Введите номер строки интересующего элемента");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца интересующего элемента");
int y = Convert.ToInt32(Console.ReadLine());

int rows = new Random().Next(3, 7);
int columns = new Random().Next(3, 7);
int [,] array = new int [rows, columns];

CreateArray(array);
FindElement(array, x, y);
PrintArray(array);
Console.WriteLine();

if (FindElement(array, x, y))
    {
        Console.WriteLine($"Искомый элемент = {array[x,y]}");
    }
    else
    {
        Console.WriteLine("Искомый элемент не найден");
    }

void CreateArray(int[,] array)
{
    for (int  i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

bool FindElement(int[,] array, int x, int y)
{
    bool result = false;
    for (int  i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == x && j == y)
            {
                result = true;
            }
        }
    }
    return result;
}

void PrintArray (int[,] array)
{
    for (int  i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
