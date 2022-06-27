using System;

class Program
{

    public static string Reverse(string text)
    {
        char[] cArray = text.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        return reverse;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Reverse("bruno"));
    }
}