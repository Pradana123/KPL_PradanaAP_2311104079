using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TpModul7_Kelompok_5
{

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class KuliahMahasiswa
    {
        public Course[] courses { get; set; }
    }

    public class KuliahMahasiswa2311104079
    {
        public static void ReadJSON()
        {
            try
            {
                string filePath = "tp7_2_2311104079.json";

                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File {filePath} tidak ditemukan!");
                    Console.WriteLine("Lokasi pencarian: " + Path.GetFullPath(filePath));
                    return;
                }



                // Baca dan deserialize file JSON
                string jsonString = File.ReadAllText(filePath);
                KuliahMahasiswa data = JsonSerializer.Deserialize<KuliahMahasiswa>(jsonString);

                Console.WriteLine("\nDaftar Mata Kuliah:");
                for (int i = 0; i < data.courses.Length; i++)
                {
                    Console.WriteLine($"Mk{i + 1}.{data.courses[i].code}-{data.courses[i].name}");
                }

            }


            catch (JsonException ex)
            {
                Console.WriteLine($"\nERROR JSON: {ex.Message}");
                Console.WriteLine($"Path: {ex.Path} | Line: {ex.LineNumber}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nERROR: {ex.Message}");
                Console.ReadLine();
            }
        }
    }
}