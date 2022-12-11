using System.Text.Json;
using Generator.Configuration;

namespace Generator.Lists;

public class ListGenerator
{
    private readonly TextRandomizer _textRandomizer;

    public ListGenerator(TextRandomizer textRandomizer)
    {
        _textRandomizer = textRandomizer;
    }

    public async Task GenerateLists(int count, string fileName)
    {
        var lists = Enumerable.Range(0, count)
            .Select(_ => new ListData(_textRandomizer.GetRandomString(10)))
            .ToList();

        var json = JsonSerializer.Serialize(lists, Config.JsonSerializerOptions);
        await File.WriteAllTextAsync(Path.Combine(Config.PathToFolderWithData, fileName), json);
    }
}