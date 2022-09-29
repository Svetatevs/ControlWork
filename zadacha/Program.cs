// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.

string[] array1 = new string[4] { "1234", "156", "-2", "computer science" };
string[] array2 = new string[array1.Length];
void FindFriDigits(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
FindFriDigits(array1, array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);

