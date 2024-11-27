namespace Код;

class Program
{
    static void Main()
    {
      int[] numbers = new int [5];
      string[] strings = ("string1", "string2", "string3");

      int[] numbers2 = (1, 2, 3);
      Console.WriteLine(numbers2[1]);
      numbers2[2] += 100;
      Console.WriteLine(numbers2.Length);

      int[] numbers3 = new int [4];
      int[] numbers4 = new int [5];
      char[] chars = new char[3];
      char[] chars2 = ("1", "2", "3", "4", "5");
    }
}
