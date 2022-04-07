// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, world!");

public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        if (a < 0 || b < 0 || c < 0)
            return false;
        return ((a + b > c) && (b+c > a) || (a + c > b));
    }
}
