class Program
{
    static void Main()
    {
        var auth = new AuthService();
        Console.WriteLine("1. Register\n2. Login\nPilih opsi:");
        string option = Console.ReadLine();

        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        if (option == "1")
        {
            bool success = auth.Register(username, password);
            Console.WriteLine(success
                ? "Registrasi berhasil!"
                : "Registrasi gagal! Username harus 8-20 huruf dan password minimal 8 karakter, mengandung angka & simbol, serta tidak mengandung username.");
        }
        else if (option == "2")
        {
            bool success = auth.Login(username, password);
            if (success)
            {
                Console.WriteLine("Login berhasil!\n");

                // Lanjut ke menu transfer
                RunTransferMenu();
            }
            else
            {
                Console.WriteLine("Login gagal! Username atau password salah.");
            }
        }
        else
        {
            Console.WriteLine("Opsi tidak valid.");
        }
    }

    static void RunTransferMenu()
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
