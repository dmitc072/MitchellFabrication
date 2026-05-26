namespace MitchellFabrication.Models;

public interface IQuoteField
{
    string Label { get; }
    string Key   { get; }
}

public record TextField    (string Label, string Key)                                : IQuoteField;
public record NumberField  (string Label, string Key)                                : IQuoteField;
public record TextareaField(string Label, string Key)                                : IQuoteField;
public record DropdownField(string Label, string Key, List<string> Options)          : IQuoteField;
public record Info         (string Label, string Key, string AutoComplete, string Type)      : IQuoteField;