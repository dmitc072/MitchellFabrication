namespace MitchellFabrication.Helpers;

public static class FormHelper
{

    public static string FormatPhone(string input)
    {
        var digits = new string(input.ToString().Where(char.IsDigit).ToArray());
        if (digits.Length > 10) digits = digits[..10];

        if (digits.Length >= 7)
            return $"{digits[..3]}-{digits[3..6]}-{digits[6..]}";
        else if (digits.Length >= 4)
            return $"{digits[..3]}-{digits[3..]}";
        else
            return digits;
    }

    public static bool IsPhoneValid(string phone) =>
         new string(phone.Where(char.IsDigit).ToArray()).Length == 10;


    public static bool IsEmailValid(string email) =>
        System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
   
}