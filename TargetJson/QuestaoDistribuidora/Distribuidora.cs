using System;

class Program
{
    static double SP = 67836.43;
    static double RJ = 36678.66;
    static double MG = 29229.88;
    static double ES = 27165.48;
    static double Outros = 19849.53;
    static double total;

    static double calculaTotal()
    {
        return total = SP + RJ + MG + ES + Outros;
    }
    static double calculaRepre(double estado)
    {
        double percentual;
        percentual = (estado * 100) / calculaTotal();
        return percentual;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(calculaTotal());
        Console.WriteLine("{0;f3}", calculaRepre(SP));
        Console.WriteLine("{0;f3}", calculaRepre(RJ));
        Console.WriteLine("{0;f3}", calculaRepre(MG));
        Console.WriteLine("{0;f3}", calculaRepre(ES));
        Console.WriteLine("{0;f3}", calculaRepre(Outros));

    }
}