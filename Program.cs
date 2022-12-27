// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам

string[] FormArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        arr[i] = Convert.ToString(Console.ReadLine())!;
    }
    return arr;
}

Console.WriteLine("Введите количество элементов для массива: ");
int count = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string[] array = FormArray(count);

Console.WriteLine("\nВаш массив: ");
Console.Write("[\"" + string.Join("\", \"", array) + "\"]");
Console.WriteLine($"\n\nНовый массив из строк, длина которых меньше или равна 3 элементам: ");

int newSize = 0;
for (int i = 0; i < count; i++)
{
    if (array[i].Length <= 3) newSize++;
}

string[] mass = new string[newSize];

string[] RequiredArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            mass[count] = array[i];
            count++;
        }
    }
    return mass;
}
mass = RequiredArray(array);
if (mass.Length == 0) Console.WriteLine("[]");
else Console.Write("[\"" + string.Join("\", \"", mass) + "\"]");