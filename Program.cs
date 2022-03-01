using GFT_Start_2.src.Entities;

public class Program
{
    public static void Main(string[] args)
    {
        var arus = new Hero("Arus", 23, "Knight");
        var wizard = new Wizard("Jennica", 23, "White Wizard");

        Console.WriteLine(arus.Attack());
        Console.WriteLine(wizard.Attack());
    }
}