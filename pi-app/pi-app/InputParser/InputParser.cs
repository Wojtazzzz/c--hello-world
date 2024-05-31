using pi_app.InputParser;

class InputParser
{
    public InputParserResponse ParseNumber(string? number)
    {
        if (String.IsNullOrEmpty(number))
        {
            return new(false, 0, "Passed value is empty.");
        }

        if (!int.TryParse(number, out var result))
        {
            return new(false, 0, "Passed value is invalid.");
        }

        return new(true, result, "Success.");
    }
    
}