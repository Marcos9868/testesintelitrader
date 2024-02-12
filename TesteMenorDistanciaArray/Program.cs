using System;
class Program
{
  static void Main()
  {
    int[] firstArray = [-1, 5, 8, 12, 18, 22, 27, 31, 35, 42];
    int[] secondArray = [26, 6, 10, 15, 20, 24, 29, 34, 39, 46];

    int minimalDistance = CalculateMinimalDistance(firstArray, secondArray);

    Console.WriteLine("A distância mínima entre as duas matrizes é: " + minimalDistance);
  }

  static int CalculateMinimalDistance(int[] array1, int[] array2)
  {
    if (array1.Length != array2.Length)
    {
      throw new ArgumentException("Os arrays devem ter o mesmo comprimento.");
    }

    int length = array1.Length;
    int minimalDistance = int.MaxValue;

    for (int i = 0; i < length; i++)
    {
      for (int j = 0; j < length; j++)
      {
        int diference = array1[i] - array2[j];
        int positiveDiference = (diference + Math.Abs(diference)) / 2;

        if (positiveDiference < minimalDistance)
        {
          minimalDistance = positiveDiference;
        }
      }
    }

    return minimalDistance;
  }
}

