void FillArray(int[] collection) //collection - название аргумента
{
    int length = collection.Length; // получть длину массива
    int index = 0; // начальная позиция индекса
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); 
         // заполняем массив рандомными числами от 1 до 10
        index++;
    }
}

void PrintArray(int[] col) //void - метод, кот не возвращает ничего
                            // на выходе. И не требует return 
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // новый метод IndexOf
// в кач аргументов массив collection и элемент find
{
    int count = collection.Length;
    int index = 0; 
    int position = 0; // позиция элемента find которую мы ищем

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // to only show the first entry
        }
        index++;
    }
    return position;

}
int[] array = new int[10]; //create new array 'array' with 10 elements

FillArray(array);
array[3] = 4; // можно принудительно заполнить некоторые 
array[7] = 4; // позиции четвёрками
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);