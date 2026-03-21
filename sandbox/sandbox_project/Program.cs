using System;

public class Program
{
    static void Main(string[] args)
    {
        var Lista = new int[3];
        Lista[0] = 1;
        Lista[1] = 3;
        foreach (var item in Lista)
        {
            Console.WriteLine(item);
        }
        
    }
}