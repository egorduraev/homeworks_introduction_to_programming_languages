/*Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

Задача 2: Задайте массив на 10 целых чисел. Напишите программу, 
которая определяет количество чётных чисел в массиве.

Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива.

Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
Создайте массив, состоящий из цифр этого числа. 
Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
Размер массива должен быть равен количеству цифр.*/

// Task 1
Random rnd = new Random();
int[] array = new int[10];
int count1 = 0, count2 = 0;
for (int i = 0; i < 10; i++) {
    array[i] = rnd.Next(1, 100);
    Console.Write(array[i] + " ");
    if (array[i] >= 20 && array[i] <= 90) count1++;
    if ((array[i] % 2) == 0) count2++;
}
Console.WriteLine("\nNumbers in range: " + count1);
Console.WriteLine("Count of even numbers: " + count2);
Random rnd1 = new Random();
int max = 0, min = 0;
double[] arrdb = new double[10];
for (int i = 0; i < 10; i++) {
    arrdb[i] = Math.Round((rnd1.NextDouble() * ((00.00) - (-100.00)) + (00.00)), 2);
    Console.Write(arrdb[i] + " ");
    if (arrdb[max] < arrdb[i]) max = i;
    if (arrdb[max] > arrdb[i]) min = i;
}
double result = arrdb[max] - arrdb[min];
Console.WriteLine("\nDifference: " + result);
int rand = rnd.Next(1, 100000);
int temp = rand;
int size = 0;
while (temp != 0) {
    size++;
    temp = temp / 10;
}
temp = rand;
int[] arr = new int[size];
Console.WriteLine("Random member: " + rand);
for (int i = size - 1; i >= 0; i--) {
    arr[i] = temp % 10;
    temp = temp / 10;
}
for (int i = 0; i < size; i++) Console.Write(arr[i] + " ");
