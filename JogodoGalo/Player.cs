using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogodoGalo
{
    public class Player
    {
        public string Name{
            get;
            private set;
        }
        public void DefiNome(string set){
            Name = set; 
        }
        public string simbulo{
            get;
            private set;

        }
        public int vitoriass;

        public Player(string sim){
            simbulo = sim;
            vitoriass = 0;
        }
         public void IncrementarVitorias(){
            vitoriass++;
        }
        public int ContarVitorias(){
            return vitoriass;
        }
    }
}