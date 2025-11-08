// Hiển thị các số nguyên tố nhỏ hơn 100
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // In các số nguyên tố nhỏ hơn 100 và đếm tổng
        int total = CountPrimesUpTo(100);
        Console.WriteLine($"Total primes < 100: {total}");
    }

    // Trả về true nếu n là số nguyên tố
    private static bool IsPrime(int n)
    {
        if (n < 2) return false;
        int limit = (int)Math.Sqrt(n);
        for (int i = 2; i <= limit; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // In các số nguyên tố < max và trả về số lượng của chúng
    private static int CountPrimesUpTo(int max)
    {
        int count = 0;
        for (int a = 2; a < max; a++)
        {
            if (IsPrime(a))
            {
                Console.WriteLine(a);
                count++;
            }
        }
        return count;
    }
}
