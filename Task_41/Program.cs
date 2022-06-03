// Пользователь вводит с клавиатуры M чисел 
// Посчитайте, сколько чисел больше 0 ввел пользователь
// ввод в цикле и сразу суммировать
// 0, 7, 8, -2, -2 == 2

int[] GenArray()
{
    Console.WriteLine("Введите число элементов массива: ");
    int n = int.Parse(Console.ReadLine());
    int[] arr = new int[n];
    Console.Write("Введите числа массива из {n} чисел: ");
    int dig = 0;
    for (int i = 0; i < n; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());

        if (arr[i] > 0)
        {
            dig++;
        }
    }
    
    Console.WriteLine();
    Console.WriteLine($"Число чисел в массиве больше 0: {dig}");
    Console.WriteLine("Числа, введенные пользователем:");
    return arr;

}

void PrintArray(int[] prarr)
{
    var str = string.Join(" ", prarr);
    Console.WriteLine(str);
}

int[] arr = GenArray();
PrintArray(arr);



