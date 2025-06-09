using System;
using System.Collections.Generic;
using System.Linq;

class DynamicArray
{
    private List<double> array;

    public DynamicArray()
    {
        array = new List<double>();
    }

    public void Add(double value)
    {
        array.Add(value);
    }

    public void InsertAt(int index, double value)
    {
        if (index < 0 || index > array.Count)
            Console.WriteLine("Неправильний індекс.");
        else
            array.Insert(index, value);
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= array.Count)
            Console.WriteLine("Неправильний індекс.");
        else
            array.RemoveAt(index);
    }

    public double? GetByIndex(int index)
    {
        if (index < 0 || index >= array.Count)
        {
            Console.WriteLine("Неправильний індекс.");
            return null;
        }
        return array[index];
    }

    public int? FindByKey(double key)
    {
        int index = array.IndexOf(key);
        return index != -1 ? index : (int?)null;
    }

    public void Display()
    {
        Console.WriteLine("Масив: " + string.Join(", ", array));
    }

    public double? GetMin()
    {
        if (array.Count == 0) return null;
        return array.Min();
    }

    public double? SumBetweenPositives()
    {
        int first = array.FindIndex(x => x > 0);
        int last = array.FindLastIndex(x => x > 0);

        if (first == -1 || last == -1 || first >= last) return 0;

        double sum = 0;
        for (int i = first + 1; i < last; i++)
            sum += array[i];

        return sum;
    }

    public void ReorderZerosFirst()
    {
        var zeros = array.Where(x => x == 0);
        var others = array.Where(x => x != 0);
        array = zeros.Concat(others).ToList();
    }
}
