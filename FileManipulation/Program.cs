namespace FileManipulation;


public class Program {
    public static void Main(string[] args) {
        // Check if a file path is provided as a command-line argument
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: WordCount <file_path>");
            return;
        }

        string filePath = args[0];

        try
        {
            ReadFile(args);

            // Count the words
            int wordCount = cleanedText.Split(' ').Length;

            // Output the result
            Console.WriteLine($"Number of words: {wordCount}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public static void ReadFile(string[] values) 
    {
        string filePath = values[0];

        string text = File.ReadAllText(filePath);

        var cleanedText = RemoveNonCharacters(text);
    }

    public static string RemoveNonCharacters(string values) 
    {
        string cleanedText = Regex.Replace(values, @"\p{P}", " ").Trim();
        return Regex.Replace(cleanedText, @"\s+", " ");
    }
}