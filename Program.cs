
using System.Linq.Expressions;
int n;
Console.Write("Введите длину массива: ");
int.TryParse(Console.ReadLine(), out n);
string[] array = EnterArray(n);
//PrintArray(array);
string[] newArray = SortByLength(array);
if (newArray.Length == 0)
{
    Console.WriteLine("");
}
else
{
    PrintArray(newArray);
}



string[] EnterArray(int _n)
{
    string[] array = new string[_n];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите следующую стоку: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] SortByLength(string[] _array)
{
    int length = 0;
    for (int i = 0; i < _array.Length; i++)
    {
        if (_array[i].Length <= 3)
        {
            length += 1;
        }
    }
    string[] newArray = new string[length];
    int count = 0;
    for (int z = 0; z < _array.Length; z++)
    {
        if (_array[z].Length <= 3)
        {
            newArray[count] = _array[z];
            count += 1;
        }
    }
    return newArray;
}

void PrintArray(string[] _ar)
{
    for (int i = 0; i < _ar.Length; i++)
    {
        if (i == _ar.Length - 1)
        {
            Console.Write($"\"{_ar[i]}\"");
        }
        else
        {
            Console.Write($"\"{_ar[i]}\", ");
        }
    }
}
