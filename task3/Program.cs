Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt16(Console.ReadLine());
Random r = new Random();
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = r.Next(0, 100);
    Console.Write(array[i] + " ");
}