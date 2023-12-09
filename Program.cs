/*Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.

Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.*/

//Task 1
string naturals(int m, int n) {
    if (m == n) return Convert.ToString(n);
    return (m + " " + naturals(m + 1, n));
};
int M = 1, N = 5;
Console.WriteLine("M = " + M + "; N = "+ N + " -> \"" + naturals(M, N) + "\"");
M = 4; 
N = 8;
Console.WriteLine("M = " + M + "; N = "+ N + " -> \"" + naturals(M, N) + "\"");

// Task 2
int Ackermann(int m, int n) {
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
};
int m = 2, n = 3;
Console.WriteLine("m = " + m + ", n = " + n + " -> A(m,n) = " + Ackermann(n, m));

// Task 3
int[] array = {1, 2, 5, 0, 10, 34};
Console.Write("[");
for (int i = 0; i < array.Length; i ++) {
    if (i == array.Length - 1) {
        Console.Write(array[i] + "] => ");
        continue;
    }
    Console.Write(array[i] + ", ");
}
void recursion(int[] array, int i = 0) {
    if (i != array.Length) {
        recursion(array, i + 1);
        Console.Write(array[i] + " ");
    }
}
recursion(array);