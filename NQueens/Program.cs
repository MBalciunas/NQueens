using System;
using System.Numerics;
class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number N for queens to be placed on NxN board, so they don't attack each other");
        var N = Convert.ToInt32(Console.ReadLine());
        int[,] board = new int[N, N];

            if (NQueens(board, N, N))
        {
            Console.WriteLine("YES");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }
        else Console.WriteLine("NO");
    }

    static bool IsAttacked(int x, int y, int[,] board, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == x || j == y || (i + j) == (x + y) || (i - j) == (x - y))
                {
                    if (board[i, j] == 1)
                        return true;
                }
            }
        }
                    return false;

    }

    static bool NQueens(int[,] board, int N, int size)
    {
        for (int v = 0; v < size; v++)
        {
            for (int b = 0; b < size; b++)
            {
                Console.Write(board[v, b]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        if (N == 0)
            return true;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (IsAttacked(i, j, board, size))
                    continue;
                board[i, j] = 1;
                if (NQueens(board, N - 1, size))
                    return true;
                board[i, j] = 0;
            }
        }
        return false;
    }
}
