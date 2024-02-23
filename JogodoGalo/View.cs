using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace JogodoGalo
{
    public class View
    {   
        private static string caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
         "estatisticas.txt");


        private Controla controla;
        public View (Controla con){
            controla = con; 
        }
        public string Nome(){
            Console.Write("Escreva o teu nome ");
            return Console.ReadLine();
        }
        public int Escolha(){
            Console.WriteLine("1 - Jogar \n2 - Estatisticas \n3 -Sair ");
            int tenta = 0;
            try{
                tenta = Convert.ToInt32(Console.ReadLine());
            }catch{
                tenta = -1;
            }return tenta;
        }

        public void Falso(){
            Console.WriteLine("Caracter errado tente de novo. ");

        }
        public void Mostra(Papel tabu){
            
            Console.WriteLine($" {tabu.Arry[0]} | {tabu.Arry[1]} | {tabu.Arry[2]} \n {tabu.Arry[3]} | {tabu.Arry[4]} | {tabu.Arry[5]} \n {tabu.Arry[6]} | {tabu.Arry[7]} | {tabu.Arry[8]} \n \n "); 
        }
        public int Joge(Player p){
            Console.WriteLine($"Joge e sua vez {p.Name}.");
            return Convert.ToInt32(Console.ReadLine());
            
            string input = Console.ReadLine();

            int jogada;
                if (int.TryParse(input, out jogada)){
                return jogada;
            }
            else{
                Console.WriteLine("Entrada inválida. Tente novamente.");   
                return Joge(p);
            }

        }
        public void gamede(Player p){
            Console.WriteLine($"Joge de novo player {p.Name}");
        }
        public void vic(Player p){
            Console.WriteLine($"A vitoria foi do {p.Name}");   
        }
        public void Empate(){
            Console.WriteLine($"Foi empate ");
        }
        public void MostraEstatisticas(int[] estatisticas){
            Console.WriteLine($"Vitorias do Jogador 1: {estatisticas[0]}");
            Console.WriteLine($"Vitorias do Jogador 2: {estatisticas[1]}");
            Console.WriteLine($"Empate: {estatisticas[2]}");    
            Console.WriteLine($"Vitorias do Jogador 1: {estatisticas[3]}");
            Console.WriteLine($"Vitorias do Jogador 2: {estatisticas[4]}"); 
        }
        public void NADA(){
            Console.WriteLine("     ");
        }

    }     

}