using System;
using System.IO;
using System.Text.Json;
using TpModul7_Kelompok_5;

namespace TpModul7_Kelompok_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n=== PROGRAM DESERIALISASI JSON ===");
            Console.WriteLine("\n=== Praktikum Modul 7 - NIM 2311104079 ===");

            Console.WriteLine("\n=============== JSON DESERIALIZATION ===============");
            Console.WriteLine("\n[1] Membaca Data Mahasiswa");
            DataMahasiswa2311104079.ReadJSON();
            
            // Jalankan fungsi kedua (Daftar Mata Kuliah)
            Console.WriteLine("\n==================MENAMBAHKAN JSON DESERIALIZATON 2=====================");
            Console.WriteLine("\n[2] MEMBACA DAFTAR MATA KULIAH");
            KuliahMahasiswa2311104079.ReadJSON();

            Console.WriteLine("\n=== SEMUA PROSES TELAH SELESAI ===");
            Console.WriteLine("Tekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}