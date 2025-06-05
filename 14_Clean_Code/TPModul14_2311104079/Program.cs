using System;

class Program
{
    static void Main()
    {
        // Input nama pengguna
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Selamat datang, {nama}!");

        // Inisialisasi dan isi array
        int[] angkaArray = new int[50];
        for (int i = 0; i < angkaArray.Length; i++)
        {
            angkaArray[i] = i;
        }

        // Tampilkan angka dengan format tertentu
        for (int i = 0; i < angkaArray.Length; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.WriteLine($"{i} #$#$");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine($"{i} ##");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"{i} $$");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

        // Input angka untuk cek bilangan prima
        Console.Write("Masukkan sebuah angka (1–10000): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int angka) && angka >= 1 && angka <= 10000)
        {
            if (IsPrime(angka))
            {
                Console.WriteLine($"Angka {angka} merupakan bilangan prima");
            }
            else
            {
                Console.WriteLine($"Angka {angka} bukan merupakan bilangan prima");
            }
        }
        else
        {
            Console.WriteLine("Input tidak valid!");
        }

        Console.ReadLine();
    }

    /// <summary>
    /// Mengecek apakah angka termasuk bilangan prima
    /// </summary>
    static bool IsPrime(int number)
    {
        if (number < 2) return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
