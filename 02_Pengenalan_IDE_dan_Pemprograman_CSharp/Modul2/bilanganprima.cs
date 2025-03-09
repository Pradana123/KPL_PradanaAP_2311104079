using System;

class Program
{
    static void Main(string[] args)
    {
        // Meminta input angka
        Console.Write("Masukkan angka (1-10000): ");
        string input = Console.ReadLine();
        int angka = Convert.ToInt32(input);

        // Memeriksa apakah angka prima
        bool isPrime = true;
        if (angka < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(angka); i++)
            {
                if (angka % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        // Menampilkan hasil
        if (isPrime)
        {
            Console.WriteLine($"Angka {angka} merupakan bilangan prima");
        }
        else
        {
            Console.WriteLine($"Angka {angka} bukan merupakan bilangan prima");
        }
    }
}
