using BenchmarkDotNet.Attributes;

namespace RegexPerformance;

public class RegexBenchmarks
{
    private readonly string validInput = "123.456.789";

    [Benchmark]
    public bool ValidateUsingSingleUseRegex()
    {
        return RegexValidator.ValidateUsingSingleUseRegex(validInput);
    }

    [Benchmark]
    public bool ValidateUsingStaticRegex()
    {
        return RegexValidator.ValidateUsingStaticRegex(validInput);
    }

    [Benchmark]
    public bool ValidateUsingStaticCompiledRegex()
    {
        return RegexValidator.ValidateUsingStaticCompiledRegex(validInput);
    }

    [Benchmark]
    public bool ValidateUsingSourceGeneratedRegex()
    {
        return RegexValidator.ValidateUsingSourceGeneratedRegex(validInput);
    }
}
