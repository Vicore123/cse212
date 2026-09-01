public class Test
{
    public static void Main()
    {
        Console.WriteLine(Sum(3));
    }

    public static int Sum(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        return n + Sum(n - 1);
    }
}