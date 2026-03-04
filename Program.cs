using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        string linha = Console.ReadLine();

        string[] valores = linha.Split(' ');

        int P1 = int.Parse(valores[0]);
        int C1 = int.Parse(valores[1]);
        int P2 = int.Parse(valores[2]);
        int C2 = int.Parse(valores[3]);

        int TorqueEsquerdo = P1*C1;
        int TorqueDireito = P2*C2;

        if (TorqueEsquerdo > TorqueDireito)
        {
            Console.WriteLine("-1");
        }

        else if (TorqueEsquerdo < TorqueDireito)
        {
            Console.WriteLine("1");
        }

        else
        {
            Console.WriteLine("0");
        }


    }
}