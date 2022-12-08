// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

Console.WriteLine("Введите массив до 8 элементов");
int [] array = new int [8];
for (int i = 0; i < 8; i++)
{
    
    array [i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"[{string.Join(", ", array)}]");
