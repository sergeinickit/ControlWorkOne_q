// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//   лучше обойтись исключительно массивами.

using System.Linq.Expressions;
class Program
{
    static void Main()
    {
        
        string[] source = {"Привет", "Мир", "364!", "Z","22","Груша"};
        string[] result = NewArrayString(source);

        foreach (var item in source)
        {
             System.Console.Write(item + " ");
        }
        System.Console.WriteLine();

        foreach (var item in result)
        {
             System.Console.Write(item + " "); 
        }
    }
 
    static string[] NewArrayString(string[] source)
    {
        int size = 0;
        
        for (int i = 0; i < source.Length; i++)
        {
            if(source[i].Length <= 3)
            {
                size ++;
            }    
        }

