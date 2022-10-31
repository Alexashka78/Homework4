// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
//           и возводит число A в натуральную степень B.
/*
Console.Write("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());

int step = a;
    
for(int i = 1; i < b; i++)
    {
        step = step * a;
    }

Console.WriteLine("A в степени B равно: " + step);
*/

 // Задача 2: Напишите программу, которая принимает 
 //           на вход число и выдаёт сумму цифр в числе.
/*
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while(a > 0)
{
    int num = a % 10;
    a = a / 10;
    sum = sum + num;
}

Console.WriteLine("Сумма чисел равна: " + sum);
*/

// Задача 3: Напишите программу, которая задаёт массив
//           из m элементов и выводит их на экран.

/*
int[] CreatesArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 100;

int[] myArray = CreatesArray(size, min, max);
ShowArray(myArray);
*/