using System;
public class Program
{

    public static void Main(String[] args)
    {
        int[] vet = new int[20];
        vet[0] = 0;
        vet[1] = 1;

        Console.WriteLine("Informe o número a ser verificado: ");
        int numero = Int32.Parse(Console.ReadLine());


        for (int i = 2; i < 20; i++)
        {
            vet[i] = vet[i - 1] + vet[i - 2];
            if (numero == vet[i])
            {
                numero = 1;
            }
        }

        if (numero == 1)
        {
            Console.WriteLine("O número pertence a sequência.");
        }
        else
        {
            Console.WriteLine("O número não pertence a sequência.");
        }

        for (int i = 0; i < 20; i++)
        {
            Console.Write("{0}, ", vet[i]);
        }


    }

}