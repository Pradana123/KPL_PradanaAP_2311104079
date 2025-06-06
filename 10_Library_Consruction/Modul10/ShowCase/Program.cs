using System;
using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        int baris = 0;
        do
        {
            if (baris == 0 || baris >= 25)
                ResetKonsol();

            Console.Write("Masukkan teks (tekan <Enter> kosong untuk keluar): ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;

            Console.WriteLine($"Teks: {input} {"Diawali huruf kapital?",30}: " +
                              $"{(input.StartsWithUpper() ? "Ya" : "Tidak")}\n");

            baris += 3;
        } while (true);

        return;

        // Method lokal untuk mereset tampilan konsol
        void ResetKonsol()
        {
            if (baris > 0)
            {
                Console.WriteLine("Tekan sembarang tombol untuk lanjut...");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("\nTekan <Enter> tanpa mengetik apapun untuk keluar.");
            Console.WriteLine("Atau masukkan sebuah kalimat lalu tekan <Enter>:\n");

            baris = 3;
        }
    }
}
