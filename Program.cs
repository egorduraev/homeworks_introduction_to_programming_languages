/*Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую 
и последнюю строку массива.

Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.

Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
Под удалением понимается создание нового двумерного массива без строки и столбца*/

//Task 1
int x, y;
int sizeX = 3, sizeY = 5;
int[,] array = new int[sizeX, sizeY];
Random random = new Random();
for (int i = 0; i < sizeX; i++) {
    for (int j = 0; j < sizeY; j ++) {
        array[i, j] = random.Next(0, 100);
        Console.Write(array[i, j] + " ");
    }
    Console.Write("\n");
}

Console.WriteLine("Введите строку:");
x = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите столбец:");
y = Convert.ToInt32(Console.ReadLine()) - 1;
if ((x < sizeX && x >= 0) && (y < sizeY && y >= 0)) Console.WriteLine("Значение: " + array[x, y]); else {
    Console.WriteLine("Данного элемента нет!");
}

//Task 2
int temp;
for (int i = 0; i < sizeY; i++) {
    temp = array[0, i];
    array[0, i] = array[sizeX - 1, i];
    array[sizeX - 1, i] = temp;
}
for (int i = 0; i < sizeX; i++) {
    for (int j = 0; j < sizeY; j ++) {
        Console.Write(array[i, j] + " ");
    }
    Console.Write("\n");
}

// Task 3
int[] sum = {0, 0, 0};
int min = 0;
for (int i = 0; i < sizeY; i++) {
    min = min + array[0, i];
}
int minLine = 0;
for (int i = 0; i < sizeX; i++) {
    for (int j = 0; j < sizeY; j ++) {
        sum[i] = sum [i] + array[i, j];
    }
    if (min > sum[i]) {
        min = sum[i];
        minLine = i;
    }
}
Console.WriteLine((minLine + 1) + " строка с наименьшей суммой элементов\n");

//Task 4
int minimal = array[0, 0];
int minimalLine = 0;
int minimalColumn = 0;
for (int i = 0; i < sizeX; i++) {
    for (int j = 0; j < sizeY; j ++) {
        if (minimal > array[i, j]) {
            minimal = array[i,j];
            minimalLine = i;
            minimalColumn = j;
        }
        Console.Write(array[i, j] + " ");
    }
    Console.Write("\n");
}
Console.Write("Минимальное значение: " + minimal + " в строке " + (minimalLine + 1) + " и в столбце " 
+ (minimalColumn + 1) + "\n");
int[,] newArray = new int[sizeX - 1, sizeY - 1];
int k = 0, g = 0;
for (int i = 0; i < sizeX - 1; i++) {
    if (i >= minimalLine) k = i + 1; else k = i;
    for (int j = 0; j < sizeY - 1; j ++) {
        if (j >= minimalColumn) g = j + 1; else g = j;
        newArray[i, j] = array[k, g];
        Console.Write(newArray[i, j] + " ");
    }
    Console.Write("\n");
}



