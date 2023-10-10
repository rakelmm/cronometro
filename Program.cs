namespace System;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundos => 10s = 10 segundos.");
        Console.WriteLine("M = Minutos => 1m = 1 minuto.");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo você deseja contar?");

        string recebeEntradaUsuario = Console.ReadLine().ToLower();
        char tipo = char.Parse(recebeEntradaUsuario.Substring(recebeEntradaUsuario.Length - 1, 1));
        int tempo = int.Parse(recebeEntradaUsuario[..^1]);
        int multiplicador = 1;

        if(tipo == 'm')
        {
            multiplicador = 60;
        }
        if(tempo == 0)
        {
            Environment.Exit(0);
        }

        PreStart(tempo * multiplicador);
        
        // Console.WriteLine(recebeEntradaUsuario);
        // Console.WriteLine(tipo);
        // Console.WriteLine(tempo);

    }

    static void PreStart(int tempo)
    {   
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go...");
        Thread.Sleep(2500);

        Iniciar(tempo);
    }
    static void Iniciar(int tempo)
    {
       
        int tempoAtual = 0;

        while(tempoAtual != tempo)
        {
            Console.Clear();
            tempoAtual++;
          
            Console.WriteLine(tempoAtual);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("StopWatch finalizado.");
        Thread.Sleep(2500);
        Menu();
    }
}