System.Console.Write($"Введите значения через запятую в одну строчку для использования в массиве: ");

string word = Console.ReadLine();

string[] CreateArray()      // Создаем массив из введенный элементов.
{
    string[] arrayAll = word.Split(",");
    return arrayAll;
}

void PrintArray(string[] array)  // Метод для вывода массива (Используется для финального массива.).
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(", ");
    }
}

string[] FinalArray()  // Метод для создания массива могласно условиям.
{
    string[] array = CreateArray();
    string Fstring = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Fstring = Fstring + array[i] + ",";
        }
    }
    Fstring = Fstring.Remove(Fstring.Length-1); // Для удаления запяитой в конце.
    string[] NewArray = Fstring.Split(",");
    return NewArray;
}


string[] array = CreateArray();
System.Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]"); // Исходный массив.
System.Console.WriteLine();
System.Console.WriteLine($"Массив согласно условиям: ");
PrintArray(FinalArray()); // Финальнй массив.









