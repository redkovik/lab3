using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Введіть масив (елементи через пробіл): ");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int lastNegativeIndex = -1;
    for (int i = arr.Length - 1; i >= 0; i--)
    {
      if (arr[i] < 0)
      {
        lastNegativeIndex = i;
        break;
      }
    }

    if (lastNegativeIndex != -1)
    {
      Console.WriteLine("Останній від'ємний елемент:" + arr[lastNegativeIndex]);
      int[] newArr = new int[arr.Length - 1];
      int newIndex = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        if (i != lastNegativeIndex)
        {
          newArr[newIndex] = arr[i];
          newIndex++;
        }
      }

      Console.WriteLine("Масив після видалення останнього від'ємного елементу: " + string.Join(" ", newArr));
    }
    else
    {
      Console.WriteLine("В масиві немає від'ємних елементів.");
      Console.WriteLine("Оригінальний масив: " + string.Join(" ", arr));
    }
  }
}
