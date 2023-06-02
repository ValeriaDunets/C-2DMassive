// Задача 47
// Задайте двумерный массив размером mxn, заполненный случайными вещественными числами

/*double [,] Create2dArray () 
{
    Console.WriteLine("Input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input minimum: ");
    int minVal = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input maximum: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

double [,] created2Array = new double [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            created2Array[i,j] = new Random().Next(minVal + maxVal + 1) + new Random().NextDouble();
        }
    }
    return created2Array;
} 

void Print2Array(double [,] array2d) 
{
    for (int i = 0; i < array2d.GetLength(0); i++) 
    {
        for (int j = 0; j < array2d.GetLength(1); j++) 
        {
            Console.Write(array2d[i,j] + " "); 
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

double [,] new2dArray = Create2dArray();
Print2Array(new2dArray);
*/

// Задача 50
//Напишите программу, которая на вход принимает позиции элемента
// в двемерном массиве и возвращает значение этого элемента
// или укаазние что элемента такого нет

int [,] Create2dArray () 
{
    int rows = new Random().Next(0,10);
    int columns = new Random().Next(0,10);
    int minVal = new Random().Next(0,10);
    int maxVal = new Random().Next(10,100);

int [,] created2Array = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            created2Array[i,j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return created2Array;
} 

void Print2Array(int [,] array2d) 
{
    for (int i = 0; i < array2d.GetLength(0); i++) 
    {
        for (int j = 0; j < array2d.GetLength(1); j++) 
        {
            Console.Write(array2d[i,j] + " "); 
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

Console.WriteLine("Input your rows element; ");
int rowElem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your colums element; ");
int columElem = Convert.ToInt32(Console.ReadLine());

bool PositionElem (int [,] array)
{
    if (rowElem > array.GetLength(0) || columElem > array.GetLength(1))

    return false;

else return true;;
}
int [,] new2dArray = Create2dArray();
Print2Array(new2dArray);
bool result = PositionElem(new2dArray);
if ( result == true)
    Console.WriteLine($"Element of {rowElem} row and column {columElem} is a {new2dArray[columElem - 1, columElem - 1]}");
    else
    Console.WriteLine("Impossible value!");


//Задача 52
// Задайте двумерныфй массив из целых чисел.
//Найдите сред арифметичекое элементов в каждом стобце

/*int [,] Create2DRandomArray (int rows, int cols, int min, int max)
{
    int [,] array = new int [rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            {
                array[i,j] = new Random().Next(min, max + 1);
            }
    }
    return array;
}

void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}

void FindSredArifmetic (int [,] array)
{   
    double sum = 0;
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        sum = sum / array.GetLength(0);
        Console.Write(sum + ", ");
    }     
}
Console.Write("Input your rows numb: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your cols numb: ");
int cols = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your min numb: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your max numb: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] newarray = Create2DRandomArray(rows, cols, min, max); //вызываем исходный массива
Show2dArray(newarray); 
Console.WriteLine();
FindSredArifmetic(newarray);
*/

