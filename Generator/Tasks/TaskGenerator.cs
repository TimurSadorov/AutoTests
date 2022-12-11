using System.Text.Json;
using Generator.Configuration;

namespace Generator.Tasks;

public class TaskGenerator
{
    private readonly TextRandomizer _textRandomizer;
    
    public TaskGenerator(TextRandomizer textRandomizer)
    {
        _textRandomizer = textRandomizer;
    }

    public async Task GenerateTasks(int count, string fileName)
    {
        var lists = Enumerable.Range(0, count)
            .Select(_ => new TaskData(_textRandomizer.GetRandomString(10)))
            .ToList();

        var json = JsonSerializer.Serialize(lists, Config.JsonSerializerOptions);
        await File.WriteAllTextAsync(Path.Combine(Config.PathToFolderWithData, fileName), json);
    }
}