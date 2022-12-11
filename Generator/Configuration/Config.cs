using System.Text.Json;

namespace Generator.Configuration;

public static class Config
{
    public const string PathToFolderWithData =
        @"C:\Programming\Development\Repositories\AutoTests\Generator\Data";

    public static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        WriteIndented = true
    };
}