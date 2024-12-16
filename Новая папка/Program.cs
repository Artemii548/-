namespace Kodik;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Введите количество NxM элементов матрицы sample: ");
        int N = 0;
        int M = 0;
        
        string str = Console.ReadLine();
        string stl = Console.ReadLine();
        N = int.Parse(str);
        M = int.Parse(stl);
        
 
        Console.WriteLine("Исходная матрица: ");
        Console.WriteLine();
        int[,] sample = new int[N, M];
        Random rnd = new Random();
 
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                sample[i, j] = rnd.Next(1, 100); // заполнение матрицы случайными числами
 
                Console.Write(sample[i, j] + " \t ");
 
                if (j == M - 1)
                    Console.WriteLine();
            }
        }
        int[,] trans = new int[M, N];
        Console.WriteLine();
        Console.WriteLine("Транспонированная матрица: ");
        Console.WriteLine();
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                trans[i, j] = sample[j, i];
                Console.Write(trans[i, j] + " \t ");
 
                if (j == M - 1)
                    Console.WriteLine();
            }
        }
 
        Console.ReadLine();
 
    }
}
