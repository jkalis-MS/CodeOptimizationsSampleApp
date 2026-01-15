using System.Globalization;

namespace Store.Reviews;

public class ReviewValidation
{
    internal record LocalizedWord(string Text, CultureInfo Culture);

    private static IEnumerable<LocalizedWord> DisallowedWords { get; } = ReviewHelper.LoadDisallowedWords();

    // Cache for filtered disallowed word lists by culture to avoid repeated filtering
    private static readonly Dictionary<CultureInfo, List<string>> _cultureWordCache = new Dictionary<CultureInfo, List<string>>();
    
    public static string StringValidation(string data, char replacementChar, CultureInfo culture)
    {
        // Get or create the filtered word list for the specific culture
        if (!_cultureWordCache.TryGetValue(culture, out var wordList))
        {
            // Filter once and cache the result
            wordList = DisallowedWords
                .Where(word => culture.Equals(CultureInfo.InvariantCulture) || culture.Equals(word.Culture))
                .Select(word => word.Text)
                .ToList();
            
            _cultureWordCache[culture] = wordList;
        }

        foreach (string word in wordList)
        {
            data = data.Replace(word, replacementChar.ToString(), ignoreCase: true, culture);
        }
        return data;
    }
}
