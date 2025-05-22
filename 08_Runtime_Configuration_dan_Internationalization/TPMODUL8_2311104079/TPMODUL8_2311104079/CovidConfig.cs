using System;
using System.IO;
using System.Text.Json;

namespace TPMODUL8_2311104079
{
    public class CovidConfig
    {
        private string filePath = "covid_config.json"; // Tambahkan filePath

        public string SatuanSuhu { get; set; } = "celcius";
        public int BatasHariDeman { get; set; } = 14;
        public string PesanDiterima { get; set; } = "Anda dapat masuk.";
        public string PesanDitolak { get; set; } = "Anda tidak dapat masuk.";

        public CovidConfig()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var config = JsonSerializer.Deserialize<CovidConfig>(json);

                    if (config != null)
                    {
                        SatuanSuhu = config.SatuanSuhu;
                        BatasHariDeman = config.BatasHariDeman;
                        PesanDitolak = config.PesanDitolak;
                        PesanDiterima = config.PesanDiterima;
                    }
                    else
                    {
                        SetDefaultValues();
                        SaveConfig();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Gagal membaca config: " + ex.Message);
                    SetDefaultValues();
                    SaveConfig();
                }
            }
            else
            {
                SetDefaultValues();
                SaveConfig();
            }
        }

        private void SetDefaultValues()
        {
            SatuanSuhu = "celcius";
            BatasHariDeman = 14;
            PesanDitolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
            PesanDiterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
        }

        public void SaveConfig()
        {
            try
            {
                string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal menyimpan config: " + ex.Message);
            }
        }

        public void UbahSatuan()
        {
            if (SatuanSuhu == "celcius")
                SatuanSuhu = "fahrenheit";
            else
                SatuanSuhu = "celcius";
        }
    }
}