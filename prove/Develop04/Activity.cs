using System.ComponentModel;

public class Activity
{
    private string _name;
    private string _startingMessage;
    private string _description;
    private string _endMessage;
    private int _duration;

    public Activity(string name, string startingMessage, string description, string endMessage, int duration)
    {
        _name = name;
        _startingMessage = startingMessage;
        _description = description;
        _endMessage = endMessage;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetStartingMessage()
    {
        return _startingMessage;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetEndMessage()
    {
        return _endMessage;
    }

    public int GetUserDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        int userDuration = int.Parse(Console.ReadLine());
        _duration = userDuration;
        Console.Clear();
        Console.WriteLine("Get ready...");
        return _duration;
        
    }

    public void SetDuration(int newDuration)
    {
        _duration = newDuration;
    }

    public void Countdown(int i)
    {
        while (i > 0)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write(new string('\b', i.ToString().Length) + new string(' ', i.ToString().Length) + new string('\b', i.ToString().Length));
            i--;
        }
    }

    public void Spinner()
    {
        int i = 0;
        while (i < 5)
        {
            Console.Write("—");

            Thread.Sleep(225);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("\\"); // Replace it with the - character
            Thread.Sleep(225);
            Console.Write("\b \b"); // Erase the - character
            Console.Write("|"); // Replace it with the - character
            Thread.Sleep(225);
            Console.Write("\b \b"); // Erase the - character            
            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(225);
            Console.Write("\b \b"); // Erase the - character
            i++;
        }
    }
}