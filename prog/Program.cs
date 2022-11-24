// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



// метод создания нового массива строк с длиной элементов не больше num из существующего массива строк.
string[] FindValueLess(string[] array, int num)
{
    string resultString = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= num) resultString = resultString + array[i] + " ";
    }
    string[] newArray = resultString.Split(" ", StringSplitOptions.RemoveEmptyEntries); // преобразую строку в массив по условию задачи
    return newArray;
}


Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string input = (Console.ReadLine()!);
int num = 3;
string[] array = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", FindValueLess(array, num))}]");