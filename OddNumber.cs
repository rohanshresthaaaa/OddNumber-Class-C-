using System;

public class OddNumber
{
    private int value;


    public OddNumber()
    {
        value = 1;
    }

    public OddNumber(int value)
    {
        if (value % 2 == 0)
        {
            throw new ArgumentException("Value must be an odd number.");
        }
        this.value = value;
    }

    
    public int GetValue()
    {
        return value;
    }

  
    public OddNumber GetNext()
    {
        return new OddNumber(value + 2);
    }

   
    public OddNumber GetPrevious()
    {
        return new OddNumber(value - 2);
    }
}

class Program
{
    static void Main()
    {
        try
        {
            OddNumber odd1 = new OddNumber(); // Default constructor
            Console.WriteLine("Odd number: " + odd1.GetValue());

            OddNumber odd2 = new OddNumber(7);
            Console.WriteLine("Odd number: " + odd2.GetValue());
            Console.WriteLine("Next odd: " + odd2.GetNext().GetValue());
            Console.WriteLine("Previous odd: " + odd2.GetPrevious().GetValue());

        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
