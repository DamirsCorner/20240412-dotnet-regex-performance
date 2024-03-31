using System.Text.RegularExpressions;

namespace RegexPerformance;

public partial class RegexValidator
{
    private const string pattern = @"^[0-9]{3}\.[0-9]{3}\.[0-9]{3}$";

    public static bool ValidateUsingSingleUseRegex(string input)
    {
        return Regex.IsMatch(input, pattern);
    }

    private static readonly Regex regex = new(pattern);

    public static bool ValidateUsingStaticRegex(string input)
    {
        return regex.IsMatch(input);
    }

    private static readonly Regex compiledRegex = new(pattern, RegexOptions.Compiled);

    public static bool ValidateUsingStaticCompiledRegex(string input)
    {
        return compiledRegex.IsMatch(input);
    }

    [GeneratedRegex(pattern)]
    private static partial Regex SourceGeneratedRegex();

    public static bool ValidateUsingSourceGeneratedRegex(string input)
    {
        return SourceGeneratedRegex().IsMatch(input);
    }
}
