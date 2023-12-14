System.Console.WriteLine($"Введите значения через запятую в одну строчку для использования в массиве: ");

string word = Console.ReadLine();

string[] CreateArray()
{
    string[] arrayAll = word.Split(",");
    return arrayAll;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(", ");
    }
}

string[] FinalArray()
{
    
}


string[] array = CreateArray();
PrintArray(array);

