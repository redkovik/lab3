using System;
using System.Linq;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Введіть елементи масиву S через пробіл: ");
    int[] S = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int sLength = S.Length;

    int maxCols = S.Max();

    int[][] M = new int[sLength][];
    for (int i = 0; i < sLength; i++)
    {
      M[i] = new int[S[i]];
    }

    Console.WriteLine($"Введіть матрицю E з {sLength} рядків та {maxCols} стовпчиків:");

    int[][] E = new int[sLength][];
    for (int i = 0; i < sLength; i++)
    {
      while (true)
      {
        Console.WriteLine($"Введіть елементи рядка {i + 1} через пробіл:");
        E[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        if (E[i].Length == maxCols)
        {
          break;
        }
        else
        {
          Console.WriteLine($"Рядок {i + 1} повинен містити {maxCols} елементів. Спробуйте ще раз.");
        }
      }
    }

    for (int i = 0; i < sLength; i++)
    {
      for (int j = 0; j < S[i]; j++)
      {
        M[i][j] = E[i][j];
      }
    }

    int maxRowIndex = Array.IndexOf(S, maxCols);

    M[maxRowIndex] = new int[maxCols];

    Console.WriteLine("Нова матриця M:");
    for (int i = 0; i < M.Length; i++)
    {
      Console.WriteLine(string.Join(" ", M[i]));
    }
  }
}
