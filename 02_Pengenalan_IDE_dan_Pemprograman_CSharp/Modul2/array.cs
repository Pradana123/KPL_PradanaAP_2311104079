using System;

class Program
{
    static void Main(string[] args)
    {
        // Membuat array dengan 50 elemen
        int[] array = new int[50];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i; // Mengisi array dengan nilai index
        }

        // Mencetak elemen array dengan kondisi tertentu
        for (int i = 0; i < array.Length; i++)
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
    }
}
