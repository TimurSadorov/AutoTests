using System.Text.Json;

namespace Test.Configuration;

public static class Settings
{
    public static readonly string Email;
    public static readonly string Password;
    public static readonly string BaseUri;

    static Settings()
    {
        var json = File.ReadAllText(
            @"C:\Programming\Development\Repositories\AutoTests\Test\Settings.json");
        var settings = JsonSerializer.Deserialize<Dictionary<string, string>>(json)
            ?? throw new AggregateException("Can't read settings from file");
        
        Email = settings["email"];
        Password = settings["password"];
        BaseUri = settings["baseUri"];
    }
}