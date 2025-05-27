using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalModul13_2311104079
{
    class Program
    {
    static void Main(string[] args)
    {
        // A. Buat dua variable dengan tipe PusatDataSingleton
        PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
        PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

        // C. Tambahkan data ke data1
        data1.AddSebuahData("Nama Anggota 1");
        data1.AddSebuahData("Nama Anggota 2");
        data1.AddSebuahData("Asisten Praktikum: Budi");

        // D. Print semua data dari data2
        Console.WriteLine("Data sebelum penghapusan:");
        data2.PrintSemuaData();

        // E. Hapus data asisten praktikum (index 2)
        data2.HapusSebuahData(2);

        // F. Print semua data dari data1
        Console.WriteLine("\nData setelah penghapusan:");
        data1.PrintSemuaData();

        // G. Print jumlah data
        Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData()}");
        Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData()}");
    }
}
}
