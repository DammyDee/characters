namespace characters;

class Program
{
    static void Main(string[] args)
    {
        string s = "6,889,899.45";
        Console.WriteLine(IsDouble(s));
        Console.WriteLine(Convert.ToDouble(s));
    }

    //Convert string to a double
    static bool IsDouble(string s)
    {   
        try{
            Convert.ToDouble(s);
        }
        catch(FormatException){
            return false;
        }
        catch(OverflowException){
            return false;
        }
        return true;
    }
}
