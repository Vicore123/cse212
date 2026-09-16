using System;

public class Program
{
    static void Main(string[] args)
    {
        string text = "abcdefgca";

        HashSet<char> seen = new HashSet<char>();
        foreach (char c in text)
        {
            if (seen.Contains(c))
            {
                Console.WriteLine($"Duplicate character found: {c}");
                break;
            }
            
           seen.Add(c);
        }
        
    }

}