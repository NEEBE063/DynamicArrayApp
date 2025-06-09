using System;

class Program
{
    static void Main()
    {
        DynamicArray arr = new DynamicArray();

        // Початкове заповнення
        arr.Add(0);
        arr.Add(-1.2);
        arr.Add(5.5);
        arr.Add(0);
        arr.Add(3.2);
        arr.Add(-4.1);
        arr.Display();

        // Додавання
        arr.InsertAt(2, 9.9);
        arr.Display();

        // Видалення
        arr.RemoveAt(1);
        arr.Display();

        // Пошук по індексу
        Console.WriteLine("Елемент з iндексом 3: " + arr.GetByIndex(3));

        // Пошук по ключу
        int? keyIndex = arr.FindByKey(0);
        Console.WriteLine("Iндекс першого елемента = 0: " + (keyIndex.HasValue ? keyIndex.ToString() : "не знайдено"));

        // Мінімальний елемент
        Console.WriteLine("Мiнiмальний елемент: " + arr.GetMin());

        // Сума між першим і останнім додатними
        Console.WriteLine("Сума мiж першим i останнiм додатними: " + arr.SumBetweenPositives());

        // Перетворення масиву: нулі спочатку
        arr.ReorderZerosFirst();
        Console.WriteLine("Пiсля сортування з нулями спочатку:");
        arr.Display();
    }
}
