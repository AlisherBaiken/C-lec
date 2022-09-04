int[] array = { 11, 21, 31, 41, 51, 16, 17, 51, 81 };
int n = array.Length;
int find = 51;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}