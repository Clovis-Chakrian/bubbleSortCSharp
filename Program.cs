// Iniciando no C#
// Para iniciar meus estudos em C# e partir para criar aplicações web com C# eu quis implementar um algoritmo de bubble sort com arrays numéricos.

class Program
{
  public static void Main(String[] args)
  {
    int[] arr = { 20, 12, 13, 1, 17, 21, 5, 4 };
    ShowArr(arr);
    BubbleSort(arr);
    ShowArr(arr);
    Console.WriteLine("Seu array foi ordenado :)");
    // Console.WriteLine("Hello World");
  }

  public static int[] BubbleSort(int[] arr)
  {
    int scans = arr.Length;
    while (scans >= 2)
    {
      for (int i = 0; i < scans - 1; i++)
      {
        if (arr[i] > arr[i + 1])
        {
          int temp = arr[i];
          arr[i] = arr[i + 1];
          arr[i + 1] = temp;
        }
      }

      scans--;
    }

    return arr;
  }

  public static void ShowArr(int[] arr)
  {
    for (int i = 0; i < arr.Length; i++)
    {
      Console.Write($"| {arr[i]} |");
    }

    Console.WriteLine("");
  }
}