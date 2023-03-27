// найти элемент массива, равный значению find
int[] array = {1, 12, 31, 4, 15, 4, 17, 18};

int n = array.Length;
int find = 4;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // остановит выполнение цикла как только
                // найдёт первый элемент равный find
                // не покажет другие индексы с таким же значением
    }
    index++;
}