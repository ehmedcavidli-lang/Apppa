List<(string input, string answer, bool correct)> feedbackData = new();

while (true)
{
    Console.Write("\nSual daxil et (və ya 'exit'): ");
    string input = Console.ReadLine();

    if (input == "exit") break;

    string answer = GenerateResponse(input);
    Console.WriteLine("🤖 Cavab: " + answer);

    Console.Write("Bu cavab düzgün idi? (bəli/xeyr): ");
    string feedback = Console.ReadLine();

    bool correct = feedback.Equals("bəli", StringComparison.OrdinalIgnoreCase);
    feedbackData.Add((input, answer, correct));

    Console.WriteLine($"Rəy qeyd edildi. Ümumi rəy sayı: {feedbackData.Count}");
}

Console.WriteLine("\n=== Rəylərin xülasəsi ===");
foreach (var f in feedbackData)
    Console.WriteLine($"[{(f.correct ? "✅" : "❌")}] {f.input} -> {f.answer}");
    

    // Sadə cavab funksiyası
    static string GenerateResponse(string input)
{
    if (input.Contains("salam", StringComparison.OrdinalIgnoreCase))
        return "Salam! Necəsən?";
    else if (input.Contains("necə", StringComparison.OrdinalIgnoreCase))
        return "Yaxşıyam, sən necəsən?";
    else if (input.Contains("hava", StringComparison.OrdinalIgnoreCase))
        return "Bugün hava çox gözəldir!";
    else
        return "Bu sual üçün cavabım yoxdur.";
}