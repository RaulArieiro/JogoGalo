    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace JogodoGalo
    {
        public class Papel
        {
            private string[] arry = new string[9];
            public string[] Arry{get{return arry;} private set{arry = value;}}

            public Papel(){
                for(int i = 0; i<9; i++ ){
                    Arry[i] = "__";
                    
                }
            }
            public bool jogada(int corde, Player jogador){
                if(Arry[corde] == "__"  ){
                    Arry[corde] = jogador.simbulo;
                    return true;
                }
                return false;
            }
            public bool comparar(){
                for(int i = 0; i<10;i++){
                    if(Arry[i] == "__"){
                        
                        return false;
                    } 
                    
                }
                return true; 
            }


        }
    }