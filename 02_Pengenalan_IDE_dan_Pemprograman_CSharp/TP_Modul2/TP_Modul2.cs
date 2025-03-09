using System;

class Program
{
    static void Main(string[] args)
    {
        // Bagian A: Menerima input satu karakter dan menentukan huruf vokal atau konsonan
        Console.Write("Masukkan satu huruf: ");
        char huruf = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Pindah ke baris baru setelah input

        // Konversi ke huruf kapital untuk memastikan konsistensi
        huruf = char.ToUpper(huruf);

        // Cek apakah huruf vokal atau konsonan
        if (huruf == 'A' || huruf == 'I' || huruf == 'U' || huruf == 'E' || huruf == 'O')
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
        }
        else if (char.IsLetter(huruf)) // Pastikan input adalah huruf
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");
        }
        else
        {
            Console.WriteLine("Input bukan huruf!");
        }

        // Bagian B: Membuat array bilangan genap dan mencetak output
        int[] bilanganGenap = new int[5];
        for (int i = 0; i < 5; i++)
        {
            bilanganGenap[i] = 2 * (i + 1); // Mengisi array dengan bilangan genap
        }

        Console.WriteLine("\nOutput bilangan genap:");
        for (int i = 0; i < bilanganGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap {i + 1} : {bilanganGenap[i]}");
        }
    }
}
