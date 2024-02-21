using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogodoGalo
{
    public class Controla
    {
      private Player p1;
      private Player p2;
      private Papel m1;
      int escolha;
      bool p;

        public Controla(Player[] jogador, Papel papel ){
          p1 = jogador[0];
          p2 = jogador[1];
          m1 = papel;
        }  

        public void Menu(View wer){
          p1.DefiNome(wer.Nome());
          p2.DefiNome(wer.Nome());

          while(!p){
            int j = wer.Escolha();
            if(j == 1){
              p = true;
            }else if(j == 2){
              p = true;
            }else if(j == 3){
              p = true;
            }else{
              p = false;
              wer.Falso();
            }
          } 
        }
        public void Jogo(View ver){
          int registo = 1;
          bool boliana = false;
          bool vitoria  = false;

          while(! vitoria){
          ver.Mostra(m1);
          int pega = ver.Joge(registo == 1? p1:p2);
          boliana = m1.jogada(pega,registo == 1? p1:p2);
          ver.Mostra(m1);
          Victory(registo == 1? p1:p2);

            if(boliana == true){
              if(registo = 2){
                resgisto = 1;
              } else{
              registo = 2;
              ver.gamede();
              }
            }
          }
        }

        public bool Victory(Player cruz, Player circulo, View ver, bool vitoria){
          if(Arry[0] = cruz.simbulo() && Arry[1] = cruz.simbulo() && Arry[2] = cruz.simbulo()){
            ver.vic();

          }else if(Arry[3] = cruz.simbulo() && Arry[4] = cruz.simbulo() && Arry[5] = cruz.simbulo()){
            ver.vic();

          }else if(Arry[6] = cruz.simbulo() && Arry[7] = cruz.simbulo() && Arry[8] = cruz.simbulo()){
            ver.vic(); ///
            
          }else if(Arry[0] = cruz.simbulo() && Arry[4] = cruz.simbulo() && Arry[8] = cruz.simbulo()){
            ver.vic();

          }else if(Arry[2] = cruz.simbulo() && Arry[4] = cruz.simbulo() && Arry[6] = cruz.simbulo()){
            ver.vic();

          }else if(Arry[1] = cruz.simbulo() && Arry[4] = cruz.simbulo() && Arry[7] = cruz.simbulo()){
            ver.vic();

          }else if(Arry[0] = cruz.simbulo() && Arry[3] = cruz.simbulo() && Arry[6] = cruz.simbulo()){
            ver.vic();

          }else if(Arry[2] = cruz.simbulo() && Arry[5] = cruz.simbulo() && Arry[8] = cruz.simbulo()){
            ver.vic();

          }else if(Arry[0] = circulo.simbulo() && Arry[1] = circulo.simbulo() && Arry[2] = circulo.simbulo()){
            ver.vic();

          }else if(Arry[3] = circulo.simbulo() && Arry[4] = circulo.simbulo() && Arry[5] = circulo.simbulo()){
            ver.vic();

          }else if(Arry[6] = circulo.simbulo() && Arry[7] = circulo.simbulo() && Arry[8] = circulo.simbulo()){
            ver.vic();///

          }else if(Arry[0] = circulo.simbulo() && Arry[4] = circulo.simbulo() && Arry[8] = circulo.simbulo()){
            ver.vic();

          }else if(Arry[2] = circulo.simbulo() && Arry[4] = circulo.simbulo() && Arry[6] = circulo.simbulo()){
            ver.vic();

          }else if(Arry[1] = circulo.simbulo() && Arry[4] = circulo.simbulo() && Arry[7] = circulo.simbulo()){
            ver.vic();

          }else if(Arry[0] = circulo.simbulo() && Arry[3] = circulo.simbulo() && Arry[6] = circulo.simbulo()){
            ver.vic();

          }else if(Arry[2] = circulo.simbulo() && Arry[5] = circulo.simbulo() && Arry[8] = circulo.simbulo()){
            ver.vic(); 
          }
          vitoria = true;
        }

        public bool Empate(){

        }
    }
}