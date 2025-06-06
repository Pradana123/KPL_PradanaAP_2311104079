using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Globalization;

public class Article
{
    [JsonPropertyName("title")]
    public string judul { get; set; }
    public string author { get; set; }
}

public class Jurnal
{
    public string journal_name { get; set; }
    public List<Article> articles { get; set; }
    public int volume { get; set; }
    public int tahun_terbit { get; set; }

    public static void ReadJson()
    {
        string pathFile = Path.Combine(Directory.GetCurrentDirectory(), "jurnal.json");
        if (File.Exists(pathFile))
        {
            string jsonData = File.ReadAllText(pathFile);
            Jurnal jurnal = JsonSerializer.Deserialize<Jurnal>(jsonData);

            Console.WriteLine($"Judul jurnal: {jurnal.journal_name}");
            Console.WriteLine("List artikel: ");
            int index = 1;
            foreach (var artikel in jurnal.articles)
            {
                Console.WriteLine($"Judul artikel {index}: {artikel.judul}");
                Console.WriteLine($"Author artikel {index}: {artikel.author}");
                index++;
            }

            Console.WriteLine($"Volume: {jurnal.volume}");
            Console.WriteLine($"Tahun terbit: {jurnal.tahun_terbit}");
        }
        else
        {
            Console.WriteLine("File tidak ditemukan");
            Console.WriteLine(pathFile);
        }
    }
}