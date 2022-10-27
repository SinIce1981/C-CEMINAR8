// //  Задача 53: Задайте двумерный массив.
// // Напишите программу, которая поменяет местами первую и последнюю строку массива.

// void Zadacha53()
// {
//     Random random = new Random();
//     int rows = random.Next(4, 8);
//     int columns = random.Next(4, 8);
//     Console.WriteLine($"Массив размера {rows}*{columns}");
//     int[,] numbers = new int[rows, columns];

//     FillArray(numbers);
//     PrintArray(numbers);
//     int maxIndex = rows - 1;
//     int maxColumns = numbers.GetLength(1);
//     for (int j = 0; j < maxColumns; j++)
//     {


//         {
//             (numbers[0, j], numbers[maxIndex, j]) = (numbers[maxIndex, j], numbers[0, j]);
//         }

//     }
//     Console.WriteLine();
//     PrintArray(numbers);
// }

// void FillArray(int[,] numbers)
// {
//     Random random = new Random();
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             numbers[i, j] = random.Next(0, 11);
//         }
//     }
// }
// void PrintArray(int[,] numbers)
// {
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(numbers[i, j] + "\t");
//         }
//         Console.WriteLine();

//     }
// }
// Zadacha53();


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// void Zadacha55()
// {
//     Random random = new Random();
//     int rows = random.Next(4,8 );
//     int columns = rows;
//     Console.WriteLine($"Массив размера {rows}*{columns}");
//     int[,] numbers = new int[rows, columns];

//     FillArray(numbers);
//     PrintArray(numbers);

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = i; j < columns; j++)
//         {
//             int temp = numbers[i, j];
//             numbers[i, j] = numbers[j, i];
//             numbers[j, i] = temp;
// // (numbers[i,j], numbers[j,i]) = (numbers[j,i], numbers[i,j]) 
//         }
//     }
// Console.WriteLine();
// PrintArray(numbers);
// }


// void FillArray(int[,] numbers)
// {
//     Random random = new Random();
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             numbers[i, j] = random.Next(0, 11);
//         }
//     }
// }
// void PrintArray(int[,] numbers)
// {
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(numbers[i, j] + "\t");
//         }
//         Console.WriteLine();

//     }
// }
// Zadacha55();


// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// void Zadacha57()
// {
//     Random random = new Random();
//     int rows = random.Next(4, 8);
//     int columns = random.Next(4, 8);
//     Console.WriteLine($"Массив размера {rows}*{columns}");
//     int[,] numbers = new int[rows, columns];

//     FillArray(numbers);
//     PrintArray(numbers);
//     int[] counts = new int[10];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             counts[numbers[i, j]]++;
//         }
//     }
//     for (int i = 0; i < 10; i++)
//     {
//         Console.WriteLine($"Количество {i} в массиве равно {counts[i]}");
//     }

// }

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 2);
        }
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();

    }
}
// Zadacha57();

// Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

// void Zadacha59()
// {
//     Random random = new Random();
//     int rows = random.Next(4, 8);
//     int columns = random.Next(4, 8);
//     Console.WriteLine($"Массив размера {rows}*{columns}");
//     int[,] numbers = new int[rows, columns];
//     FillArray(numbers);
//     PrintArray(numbers);

//     int min = numbers[0, 0];
//     int i_min = 0;
//     int j_min = 0;

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             if (numbers[i, j] < min)
//             {
//                 min = numbers[i, j];
//                 i_min = i;
//                 j_min = j;
//             }
//         }

//     }
//     Console.WriteLine();
//     Console.WriteLine($"N[{i_min + 1}, {j_min + 1}]={min}");

//     int rowsResult = rows - 1;
//     int columnsResult = columns - 1;

//     int[,] result = new int[rowsResult, columnsResult];
//     int bias_i = 0;
//     int bias_j = 0;

//     for (int i = 0; i < rowsResult; i++)

//     {
//         if (i == i_min) bias_i++;
//         bias_j = 0;
//         for (int j = 0; j < columnsResult; j++)
//         {
//             if (j == j_min) bias_j++;

//             result[i, j] = numbers[i + bias_i, j + bias_j];
//         }
//     }
//     Console.WriteLine();
//     PrintArray(result);

// }
// Zadacha59();


// Задача доп 


Random random = new Random();
int rows = 5;
int columns = 5;
Console.WriteLine($"Массив размера {rows}*{columns}");
int[,] map = new int[rows, columns];
FillArray(map);
int i_max = rows - 1;
int j_max = columns - 1;
map[0, 0] = 1;
map[i_max, j_max] = 1;
PrintArray(map);
bool exit = false;
FindPath(map);

if (exit) Console.WriteLine("Выход есть");
else Console.WriteLine("Выхода нет");
Console.WriteLine();
PrintArray (map);

void FindPath(int[,] map, int i = 0, int j = 0)
{
    if (i < 0 
    || i > i_max
    || j < 0
    || j > j_max
    || map[i, j] == 0
    || map[i, j] == 2)
    {
        return;
    }

if (i==i_max && j==j_max)
{
exit = true;
return;
}

map[i, j] = 2;
FindPath(map, i+1, j);
FindPath(map, i-1, j);
FindPath(map, i, j+1);
FindPath(map, i, j-1);
FindPath(map, i+1, j+1);
FindPath(map, i-1, j-1);
FindPath(map, i+1, j-1);
FindPath(map, i-1, j+1);


}

;