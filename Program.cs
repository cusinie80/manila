using System;
class week
{
    private string[] days =
    { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < days.Length)
                return days[index];
            else
                return "Invalid index";
        }
        set
        {
            if (index >= 0 && index < days.Length)
                days[index] = value;

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        week week = new week();
        Console.WriteLine(week[0]);
        Console.WriteLine(week[1]); 
        Console.WriteLine(week[2]); 
        week[0] = "sun";
        Console.WriteLine(week[0]); 
    }
}