using System.Text.Json;

public class BankTransferConfig
{
    public string lang { get; set; }
    public Transfer transfer { get; set; }
    public List<string> methods { get; set; }
    public Confirmation confirmation { get; set; }

    public static BankTransferConfig Load(string path)
    {
        if (!File.Exists(path))
        {
            var defaultConfig = new BankTransferConfig
            {
                lang = "en",
                transfer = new Transfer { threshold = 25000000, low_fee = 6500, high_fee = 15000 },
                methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
                confirmation = new Confirmation { en = "yes", id = "ya" }
            };

            var json = JsonSerializer.Serialize(defaultConfig, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
            return defaultConfig;
        }
        else
        {
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<BankTransferConfig>(json);
        }
    }
}

public class Transfer
{
    public int threshold { get; set; }
    public int low_fee { get; set; }
    public int high_fee { get; set; }
}

public class Confirmation
{
    public string en { get; set; }
    public string id { get; set; }
}
