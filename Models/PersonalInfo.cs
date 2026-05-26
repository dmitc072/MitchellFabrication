namespace MitchellFabrication.Models;

public class PersonalInfo
{
    public Dictionary<string, string> FormValues { get; set; } = new()
    {
        ["firstName"] = "",
        ["lastName"]  = "",
        ["phone"]     = "",
        ["email"]     = "",
        ["city"]      = "",
        ["state"]     = "",
    };

    public List<IQuoteField> Fields { get; } = new()
    {
        new Info("FIRST NAME",    "firstName", "given-name",  "text"),
        new Info("LAST NAME",     "lastName",  "family-name", "text"),
        new Info("PHONE NUMBER",  "phone",     "tel",         "text"),
        new Info("EMAIL ADDRESS", "email",     "email",       "email"),
        new Info("STATE",         "state",     "address-level1", "text"),
        new Info("CITY",          "city",      "address-level2", "text"),
    };
}
