
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */

Console.Write("Введите элементы(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int AddNumber(int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Кол-во элементов > 0:  {count}");
    return count;
}
AddNumber(array);

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

void GetCrossPoint(double k1, double b1, double k2, double b2)
{
    Console.WriteLine($"Точка пересечения двух прямых y = {k1} * x + {b1}, y = {k2} * x + {b2} :  ({(b2-b1)/(k1-k2)} , {k1*(b2-b1)/(k1-k2)+b1}).");
}

int GetNumber(string number) {
    Console.WriteLine(number);
    return Convert.ToInt32(Console.ReadLine());
}

double k1 = GetNumber("Введите k1");
double b1 = GetNumber("Введите b1");
double k2 = GetNumber("Введите k2");
double b2 = GetNumber("Введите b2");

GetCrossPoint(k1, b1, k2, b2);


/*
 Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
 */

void RandomArray(int from, int to, int[] arr) {
    int count = arr.Length;
    int index = 0;
    while (index < count)
    {
        arr[index] = new Random().Next(from,to);
        index++; 
    }
}

void Print(int[] randomArray) {
    int count = randomArray.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(randomArray[pos]);
        pos++;
    }
}

int[] CopyArray(int[] ar) {
    int[] arr = new int[ar.Length];
    for (int i = 0; i < ar.Length; i++)
    {
        arr[i] = ar[i];
    }
    return arr;
}


int[] arrayMain = new int[4];
RandomArray(
    -99, 99, arrayMain
);
Print(
    arrayMain
);
Console.WriteLine();
int[] arrayCopy = CopyArray(arrayMain);
Print(arrayCopy);
Console.WriteLine();


