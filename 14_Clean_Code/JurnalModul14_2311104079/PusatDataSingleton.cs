using System;
using System.Collections.Generic;

namespace PusatDataSingleton
{
    public class PusatData
    {
        private static PusatData? _instance;
        private List<string> data = new();

        // Constructor private agar tidak bisa diinstansiasi dari luar
        private PusatData() { }

        // Method untuk mendapatkan satu-satunya instance (Singleton)
        public static PusatData GetInstance()
        {
            if (_instance == null)
                _instance = new PusatData();
            return _instance;
        }

        public void TambahkanData(string item)
        {
            data.Add(item);
        }

        public void HapusSebuahData(int index)
        {
            if (index >= 0 && index < data.Count)
                data.RemoveAt(index);
        }

        public void PrintSemuaData()
        {
            Console.WriteLine("Isi Data:");
            foreach (var item in data)
                Console.WriteLine("- " + item);
        }
    }
}
