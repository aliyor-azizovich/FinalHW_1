class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите элементы массива через запятую: ");
        string input = Console.ReadLine();

        string[] array = input.Split(", ");

        string[] newArray = FilterArray(array);

        Console.WriteLine("Новый массив:");
        PrintArray(newArray);
    }

    static string[] FilterArray(string[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                count++;
            }
        }

        string[] filteredArray = new string[count];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                filteredArray[index] = arr[i];
                index++;
            }
        }

        return filteredArray;
    }

    static void PrintArray(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}