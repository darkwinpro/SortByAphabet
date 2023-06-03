using System;

public class Program
{
    public static void Main()
    {
        int countWords = Int32.Parse(Console.ReadLine()!);
        string[] arrayWords = new String[countWords];

        for (var i = 0; i < arrayWords.Length; i++)
        {
            arrayWords[i] = Console.ReadLine()!;
        }
        //цикл перемещающий границу (справа отсортирован, а слева неотсортированная часть)
        for (int firstUnsortedIndex = 0; firstUnsortedIndex < arrayWords.Length; firstUnsortedIndex++)
        {
            string minElement = arrayWords[firstUnsortedIndex];
            int minElementIndex = firstUnsortedIndex;
            //поиск минимального элемента в правой (неотсортированной) части
            for (int i = firstUnsortedIndex; i < arrayWords.Length; i++)
            {
                if ( arrayWords[i].CompareTo(minElement) < 0)
                {
                    minElement = arrayWords[i];
                    minElementIndex = i;
                }
            }
           
            var temp = arrayWords[firstUnsortedIndex];
            arrayWords[firstUnsortedIndex] = minElement;
            arrayWords[minElementIndex] = temp;
        }

        foreach (var word in arrayWords)
        {
            Console.WriteLine(word);
        }
    }
}