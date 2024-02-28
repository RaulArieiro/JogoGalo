using System;
using System.Security.Cryptography;

namespace JogodoGalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player cruz = new Player("X");
            Player circulo = new Player("0");
            Papel posicoes = new Papel();
            Estatisticas estistis = new Estatisticas();
            Controla control = new Controla(new Player[2]{cruz, circulo},posicoes,estistis);
            View ver = new View(control);
             
            
            control.Iniciar(ver);
            
            
            
        }
    }
}
