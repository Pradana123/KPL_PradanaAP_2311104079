using System.Text.Json;

public class AuthService
{
    private const string FilePath = "users.json";
    private List<User> users;

    public AuthService()
    {
        if (File.Exists(FilePath))
        {
            string json = File.ReadAllText(FilePath);
            users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }
        else
        {
            users = new List<User>();
        }
    }

    public bool Register(string username, string password)
    {
        if (username.Length < 8 || username.Length > 20 || !username.All(char.IsLetter))
            return false;

        if (password.Length < 8 || password.Length > 20 || !password.Any(char.IsDigit) || !password.Any(c => "!@#$%^&*".Contains(c)) || password.Contains(username))
            return false;

        if (users.Any(u => u.Username == username)) return false;

        var user = new User
        {
            Username = username,
            PasswordHash = PasswordHelper.Hash(password)
        };

        users.Add(user);
        Save();
        return true;
    }

    public bool Login(string username, string password)
    {
        var user = users.FirstOrDefault(u => u.Username == username);
        return user != null && user.PasswordHash == PasswordHelper.Hash(password);
    }

    private void Save()
    {
        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }
}
