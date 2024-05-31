class Guide
{
    private readonly HashSet<string> _gameNotOverAvailablePrompts = new (StringComparer.OrdinalIgnoreCase)
    {
        "yes",
        "of course",
        "yup",
        "y"
    };
    
    public void SayHello()
    {
        Console.WriteLine("Hello in PiApp!");
        Console.WriteLine("My name is Guido and I am your Guide guy.");
        Console.WriteLine("Nice to meet you!");
    }
    
    public void SayGoodbye()
    {
        Console.WriteLine("Ok. Thank for coming, bye!");
    }

    public string? GetNumberFromUser()
    {
        Console.WriteLine("Please, give me any number.");
        
        return Console.ReadLine();
    }
    
    public void ScreamForInvalidInput(string reason)
    {
        Console.WriteLine("Oh man! You passed to me invalid number... What a shame!");

        if (reason.Length > 0)
        {
            Console.WriteLine($"Our guard said: {reason}");
        }
    }

    public void AnnouncePiResult(double userInput, double result)
    {
        Console.WriteLine($"Great! This is your number ({userInput}) multiplied by PI number: {result}");
    }

    public bool IsGameOver()
    {
        Console.WriteLine("Your game is over, would you like to play again (yes/no)?");
        
        var answer = Console.ReadLine();
        
        return answer is null || !this._gameNotOverAvailablePrompts.Contains(answer);
    }
}