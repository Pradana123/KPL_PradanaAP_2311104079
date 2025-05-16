using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TpModul7_Kelompok_5
{
    // Class untuk menyimpan data nama (depan dan belakang)
    public class Nama
    {
        [JsonPropertyName("depan")]
        public string Depan { get; set; }

        [JsonPropertyName("belakang")]
        public string Belakang { get; set; }
    }

    // Class untuk menyimpan data mahasiswa
    public class DataMahasiswa
    {
        [JsonPropertyName("nama")]
        public Nama Nama { get; set; }

        [JsonPropertyName("nim")]
        public long NIM { get; set; }

        [JsonPropertyName("fakultas")]
        public string Fakultas { get; set; }
    }

    // Class untuk membaca file JSON dan deserialisasi data
    public class DataMahasiswa2311104079
    {
        public static void ReadJSON()
        {
            try
            {
                string filePath = "tp7_1_2311104079.json";

                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File \"{filePath}\" tidak ditemukan!");
                    Console.WriteLine("Lokasi dicari di: " + Path.GetFullPath(filePath));
                    return;
                }

                string jsonString = File.ReadAllText(filePath);
                DataMahasiswa data = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);

                if (data != null && data.Nama != null)
                {
                    Console.WriteLine($"Nama: {data.Nama.Depan} {data.Nama.Belakang}");
                    Console.WriteLine($"NIM : {data.NIM}");
                    Console.WriteLine($"Fakultas: {data.Fakultas}");
                }
                else
                {
                    Console.WriteLine("Data tidak lengkap atau format JSON tidak sesuai.");
                }
            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine($"Error saat membaca JSON: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            }
        }
    }
}