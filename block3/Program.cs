using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Введіть кількість рядків у зубчастому масиві: ");
    int numRows = int.Parse(Console.ReadLine());
    int[][] jaggedArray = new int[numRows][];

    for (int i = 0; i < numRows; i++)
    {
      Console.Write($"Введіть елементи рядка {i + 1} через пробіл: ");
      jaggedArray[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    }


    Console.Write("Введіть число K (кількість нових рядків, які треба додати перед першим рядком): ");
    int k = int.Parse(Console.ReadLine());

    int[][] newJaggedArray = new int[numRows + k][];

    for (int i = 0; i < k; i++)
    {
      newJaggedArray[i] = new int[0];
    }

    for (int i = 0; i < numRows; i++)
    {
      newJaggedArray[i + k] = jaggedArray[i];
    }

    Console.WriteLine("Новий зубчастий масив:");
    for (int i = 0; i < newJaggedArray.Length; i++)
    {
      Console.WriteLine($"Рядок {i + 1}: " + string.Join(" ", newJaggedArray[i]));
    }
  }
}
