1 среднее арифметическое


int[,] Create2DArray(int columns, int rows)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = i + j;
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Summ(int[,]array)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {  int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i , j];

        }
        Console.Write($"{ sum / array.GetLength(0)} ");
        
    }
      
    Console.ReadLine();

}
  
Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] MyArray = Create2DArray(columns, rows);
Show2DArray(MyArray);
Console.WriteLine();
Summ(MyArray);


2  вещественные числа
double[,] Create2DArray(int rows,int columns)
{
    Random rnd = new Random();
    double[,] array = new double[rows, columns]; // квадратные скобки
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)   
        {
            array[i, j] =  Math.Round(-20 + rnd.NextDouble() * (20 + 20), 2);
        }
    }
    return array;
}

void Show2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " -- ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}





Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] MyArray = Create2DArray(columns, rows);
Show2DArray(MyArray);
Console.WriteLine();



3 Возвращает значение элемента при вводе его позиции

void Position(int[,] array, int poc1 , int poc2)
{
            if (poc1 < 0 || poc1 > array.GetLength(0) || poc2 <0 || poc2 > array.GetLength(1))
            {
                Console.WriteLine("Данного числа нет");
            }               
              Console.WriteLine($" Число {array[poc1, poc2]}");      
}




int[,] Create2DArray(int columns, int rows)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = i + j;
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

  
Console.WriteLine("Номер строки: ");
int poc1 = Convert.ToInt32(Console.ReadLine());
  
Console.WriteLine("Номер столбца: ");
int poc2 = Convert.ToInt32(Console.ReadLine());
  
Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] MyArray = Create2DArray(columns, rows);
Show2DArray(MyArray);
Console.WriteLine();
int[,] array = Create2DArray(columns, rows);
Position(array, poc1, poc2);
