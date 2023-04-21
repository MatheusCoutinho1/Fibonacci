using System;

class Program
{
    static void Main(string[] args)
    {
        // Informe o número a ser verificado na sequência de Fibonacci
        int numero = 21;

        int a = 0, b = 1, c = 0;
        bool pertence = false;

        while (c <= numero)
        {
            if (c == numero)
            {
                pertence = true;
                break;
            }

            c = a + b;
            a = b;
            b = c;
        }

        if (pertence)
        {
            Console.WriteLine("O número " + numero + " pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine("O número " + numero + " não pertence à sequência de Fibonacci.");
        }
    }
}
