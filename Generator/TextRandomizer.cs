using System.Text;

namespace Generator;

public class TextRandomizer
{
    private readonly Random _random;
    private static readonly char[] AllowedChars =
		"0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();

	public TextRandomizer(Random random)
	{
		_random = random;
	}

	public string GetRandomString(int length)
	{
		var output = new StringBuilder();

		for (var i = 0; i < length; i++)
		{
			output.Append(GetRandomArrayElement(AllowedChars));
		}

		return output.ToString();
	}

	private T GetRandomArrayElement<T>(IList<T> array)
	{
		return array[_random.Next(array.Count)];
	}
}