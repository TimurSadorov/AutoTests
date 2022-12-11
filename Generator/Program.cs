using Generator;
using Generator.Lists;
using Generator.Tasks;

var textRandomizer = new TextRandomizer(new Random(DateTime.Now.Millisecond));

await new ListGenerator(textRandomizer).GenerateLists(2, "lists.json");

await new TaskGenerator(textRandomizer).GenerateTasks(5, "tasks.json");