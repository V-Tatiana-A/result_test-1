

using static System.Console;
Clear();
WriteLine("Введите элементы массива через знак ;");
WriteLine("!Пробел также является символом, пустая строка также может быть включена в массив!");
string[] Array=ReadLine()!.Split(";");
WriteLine();
WriteLine("Вы задали следующий массив:");
WriteLine($"['{String.Join("' ; '", Array)}']");
WriteLine();

if(GetNumberOfRequiredElements(Array)==0)
{
    WriteLine("В заданном массиве нет искомых элементов");
    WriteLine("[]");
}
else 
{
    string[] result_array = GetNewArryFromRequiredElements(Array, GetNumberOfRequiredElements(Array));
    WriteLine("Новый массив, содержащий только строки длиной до 3 символов:");
    WriteLine($"['{String.Join("' ; '", result_array)}']");
}






// methods

int GetNumberOfRequiredElements(string[] Input)
{
    int count = 0;
    for (int j = 0; j < Array.Length; j++)
    {
        if (Array[j].Length < 4)
        {
            count += 1;
        }
    }
    return count;
}


string[] GetNewArryFromRequiredElements(string[] Input, int count)
{
    string[] Output = new string[count];
    for (int i=0 , j=0 ; (i < Output.Length); j++)
    {
        if(Input[j].Length < 4)
        {
            Output[i]=Input[j];
            i+=1;
        }
    }
    return Output;
}