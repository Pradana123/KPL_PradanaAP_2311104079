class Program
{
    static void Main()
    {
        var config = BankTransferConfig.Load("bank_transfer_config.json");

        string promptAmount = config.lang == "en"
            ? "Please insert the amount of money to transfer:"
            : "Masukkan jumlah uang yang akan di-transfer:";

        Console.WriteLine(promptAmount);
        int amount = int.Parse(Console.ReadLine());

        int fee = amount <= config.transfer.threshold
            ? config.transfer.low_fee
            : config.transfer.high_fee;

        int total = amount + fee;

        if (config.lang == "en")
        {
            Console.WriteLine("Transfer fee = " + fee);
            Console.WriteLine("Total amount = " + total);
            Console.WriteLine("Select transfer method:");
        }
        else
        {
            Console.WriteLine("Biaya transfer = " + fee);
            Console.WriteLine("Total biaya = " + total);
            Console.WriteLine("Pilih metode transfer:");
        }

        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        Console.ReadLine(); // pilihan metode

        string confirmMsg = config.lang == "en"
            ? $"Please type \"{config.confirmation.en}\" to confirm the transaction:"
            : $"Ketik \"{config.confirmation.id}\" untuk mengkonfirmasi transaksi:";

        Console.WriteLine(confirmMsg);
        string input = Console.ReadLine();

        bool confirmed = (config.lang == "en" && input == config.confirmation.en)
                      || (config.lang == "id" && input == config.confirmation.id);

        string result = config.lang == "en"
            ? confirmed ? "The transfer is completed" : "Transfer is cancelled"
            : confirmed ? "Proses transfer berhasil" : "Transfer dibatalkan";

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
