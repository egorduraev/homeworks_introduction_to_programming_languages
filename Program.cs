/*Задача 1: Задайте двумерный массив символов (тип char [,]). 
Создать строку из символов этого массива.

Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
Сформировать строку, в которой слова расположены в обратном порядке. 
В полученной строке слова должны быть также разделены пробелами.*/

// Task 1
char[,] symbols = {
    {'a', 'b', 'c'},
    {'d', 'e', 'f'}
};
string str = "";
for (int i = 0; i < 2; i++) {
    for (int j = 0; j < 3; j++) {
        str = str + Convert.ToString(symbols[i, j]);
    }
}
Console.WriteLine(str);

// Task 2
string text = "aBcD1ef!-";
Console.WriteLine(text);
string newText = text.ToLower(); 
Console.WriteLine(newText);

// Task 3
Console.WriteLine("Введите текст: ");
string mPalindrome = Console.ReadLine();
bool check = true;
for (int i = 0; i < mPalindrome.Length; i++) {
    if (mPalindrome[i] != mPalindrome[mPalindrome.Length - 1 -i]) {
        check = false;
        break;
    }
}
Console.WriteLine((check == true) ? "Да" : "Нет");

// Task 4
string Line = "Hello my world";
Console.WriteLine(Line);
string flipped = "";
string temp = "";
for (int i = 0; i < Line.Length; i++) {
    if (Line[i] == ' ') {
        flipped =  temp + "  " + flipped; 
        temp = "";
    }
    else if (i == Line.Length - 1) {
        temp = temp + Line[i];
        flipped =  temp + "  " + flipped; 
        temp = "";
    } else temp = temp + Line[i];
}
Console.WriteLine(flipped);
