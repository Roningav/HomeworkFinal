/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string element = Console.ReadLine();
        Console.Clear();
        array[i] = element;
    }
}
void PrintArray(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        if (j == 0)
        {
            Console.Write($"[{array[j]}, ");
        }
        else if (j == array.Length - 1)
        {
            Console.Write($"{array[j]} ]");
        }
        else
        {
            Console.Write($"{array[j]}, ");
        }
    }
    Console.WriteLine();
}

void QuantityOfSymbols(string[] array)
{
    string[] array2 = new string[array.Length];
    int count = 0;
    for (int k = 0; k < array.Length; k++)
    {
        if (array[k].Length < 4)
        {
            array2[count] = array[k];
            if (count == 0)
            {
                Console.Write($"[{array2[count]}, ");
            }
            else if (k == array.Length - 1)
            {
                Console.Write($"{array2[count]}]");
            }
            else
            {
                Console.Write($"{array2[count]}, ");
            }
            count++;
        }
    }
}
Console.WriteLine("How many elements would you like to write?");
int length = int.Parse(Console.ReadLine());
string[] array = new string[length];
FillArray(array);
PrintArray(array);
QuantityOfSymbols(array);