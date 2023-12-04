/*Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет 
последним, второй – предпоследним и т.д.)*/

// Task 1
string str;
int number;
Console.Write("Введите целое число:");
do {
    str = Console.ReadLine();
    if (str == "q") {
        Console.WriteLine("Выход из программы");
        break;
    }
if(!int.TryParse(str, out number))
    Console.WriteLine("Нужно вводить целое число"); else {
        if ((number % 2) == 0) {
            Console.WriteLine("Выход из программы");
            break;
        }
    }
    Console.WriteLine("Вводите еще раз!");
} while (true);

// Task 2
Random rnd = new Random();
int[] array = new int[10];
int counter = 0;
for (int i = 0; i < 10; i++) {
    array[i] = rnd.Next(99, 1000);
    if ((array[i] % 2) == 0) counter++;
    Console.Write(array[i] + " ");
}
Console.WriteLine("\nКоличество четных чисел: " + counter);

// Task 3
Console.Write("Введите размер матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] oneDimArr = new int[size];
Console.Write("Исходная матрица: ");
for (int i = 0; i < size; i++) {
    oneDimArr[i] = rnd.Next(0, 1000);
    Console.Write(oneDimArr[i] + " ");
}
int temp = 0;
for (int i = 0; i < size/2; i++) {
    temp = oneDimArr[i];
    oneDimArr[i] = oneDimArr[size - 1 - i];
    oneDimArr[size - 1 - i] = temp;
}
Console.Write("\nПеревёрнутая матрица: ");
for (int i = 0; i < size; i++) {
    Console.Write(oneDimArr[i] + " ");
}

    
