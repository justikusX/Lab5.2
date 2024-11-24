
using System;
class Program
{
    static void Main()
    {
        string input = "дота это не игра - это целая жизнь. о боги что случилось.третье предложение."; 
        string formattedText = FormatText(input);
        Console.WriteLine(formattedText);
    }

    static string FormatText(string text)
    {
        // Разбиваем текст на предложения по точкам \\
        string[] sentences = text.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < sentences.Length; i++)
        {
            // Убираем лишние пробелы, если есть, и добавляем пробел после точки \\
            sentences[i] = sentences[i].Trim();
            if (sentences[i].Length > 0)
            {
                // Делаем первую букву заглавной \\
                sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
            }
        }

        // Объединяем предложения обратно с точками \\
        return string.Join(". ", sentences) + (sentences.Length > 0 ? "." : "");
    }
}