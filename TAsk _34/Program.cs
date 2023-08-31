int[] arr = new int[10]; // создаем массив из 10 элементов
Random rand = new Random(); // создаем объект класса Random

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(100, 1000); // заполняем элементы массива случайными трехзначными числами
}
Console.WriteLine(arr);
// преобразуем массив в строку в виде массива и выводим его на консоль
string arrStr = "[" + string.Join(", ", arr) + "]";

// Выводим на экран массив
Console.WriteLine(arrStr); 

// Количество чётных элементов
int z = 0; 
// Проходимся по массиву в поисках чётных элементов и при нахождении таковых увеличиваем z на 1
for (int x = 0; x < arr.Length; x++)
{
        if (arr[x] % 2  == 0)
        {
                z = z+1;
        }

}

Console.WriteLine(z);