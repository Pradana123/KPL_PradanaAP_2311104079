using System;
using TPMODUL8_2311104079;

class Program
{
    static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();

        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {config.SatuanSuhu}:");
        double suhu = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        int hari = Convert.ToInt32(Console.ReadLine());

        bool suhuValid = false;
        if (config.SatuanSuhu == "celcius")
        {
            suhuValid = (suhu >= 36.5 && suhu <= 37.5);
        }
        else if (config.SatuanSuhu == "fahrenheit")
        {
            suhuValid = (suhu >= 97.7 && suhu <= 99.5);
        }

        bool hariValid = (hari < config.BatasHariDeman);

        if (suhuValid && hariValid)
        {
            Console.WriteLine(config.PesanDiterima);
        }
        else
        {
            Console.WriteLine(config.PesanDitolak);
        }

        // Ubah satuan
        config.UbahSatuan();
        Console.WriteLine($"Satuan suhu telah diubah ke {config.SatuanSuhu}");
    }
}
