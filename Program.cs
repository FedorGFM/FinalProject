System.Console.Write("Введите количество элементов массива: ");
int countElements = Convert.ToInt32(Console.ReadLine());

string[] stringArray = new string[countElements];
for (int i = 0; i < stringArray.Length; i++)
{
    Console.Write($"Введите элемент массива {i}: ");
    stringArray[i] = Console.ReadLine();
}

string[] stringArrEll = StringArrayElements(stringArray);

PrintArray(stringArray);
Console.Write(" -> ");
PrintArray(stringArrEll);

string[] StringArrayElements(string[] arr)
{
    int index = 0;
    string[] stringArr = new string[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i].Length <= 3)
        {
            stringArr[index] = arr[i];
            index++;
        }
    }

    string[] resultArr = new string[index];
    for (int i = 0; i < resultArr.GetLength(0); i++)
    {
        resultArr[i] = stringArr[i];
    }
    return resultArr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"\"{arr[i]}\"" + ", ");
        else Console.Write($"\"{arr[i]}\"");
    }
    Console.Write("]");
}