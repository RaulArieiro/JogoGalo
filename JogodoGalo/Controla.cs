using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogodoGalo
{
    public class Controla
    {  
      private int[] estatisticas = new int[3];
      public Player p1;
      public Player p2;
      public Papel m1;
      public Estatisticas estatis;
      int escolha;
      bool p;
      bool vitoria  = false;
      public int[] ficheiro = new int[88888]; 
      int[] estatisticasDoJogo;


        public Controla(Player[] jogador, Papel papel ){
          p1 = jogador[0];
          p2 = jogador[1];
          m1 = papel;
          estatis = new Estatisticas();
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
          bool cheio = false;

          while(!vitoria){
          ver.Mostra(m1);
          int pega = ver.Joge(registo == 1? p1:p2);
          boliana = m1.jogada(pega,registo == 1? p1:p2);
          ver.Mostra(m1);
          cheio = m1.comparar(ver);

            if(boliana == true){
              if(registo == 2){
                registo = 1;
                ver.gamede(p1);
                estatisticas[2]++;
              }else{
                registo = 2;
                ver.gamede(p2);
                estatisticas[2]++;
              }
            }
          }
          if(cheio){
            estatisticasDoJogo[2]++;
            ver.Empate();
            Victory(registo == 1? p1:p2, ver, m1);
          }
          SalvarEstatisticas();
        }
        public int[] ObterEstatisticas(){
        return estatisticas;
        }

        public void Victory(Player cruz, View ver, Papel m1){
          if(m1.Arry[0] == cruz.simbulo && m1.Arry[1] == cruz.simbulo && m1.Arry[2] == cruz.simbulo){
            ver.vic(cruz);
            vitoria = true;

          }else if(m1.Arry[3] == cruz.simbulo && m1.Arry[4] == cruz.simbulo && m1.Arry[5] == cruz.simbulo){
            ver.vic(cruz);
            vitoria = true;

          }else if(m1.Arry[6] == cruz.simbulo && m1.Arry[7] == cruz.simbulo && m1.Arry[8] == cruz.simbulo){
            ver.vic(cruz); ///
            vitoria = true;
            
          }else if(m1.Arry[0] == cruz.simbulo && m1.Arry[4] == cruz.simbulo && m1.Arry[8] == cruz.simbulo){
            ver.vic(cruz);
            vitoria = true;

          }else if(m1.Arry[2] == cruz.simbulo && m1.Arry[4] == cruz.simbulo && m1.Arry[6] == cruz.simbulo){
            ver.vic(cruz);
            vitoria = true;

          }else if(m1.Arry[1] == cruz.simbulo && m1.Arry[4] == cruz.simbulo && m1.Arry[7] == cruz.simbulo){
            ver.vic(cruz);
            vitoria = true;

          }else if(m1.Arry[0] == cruz.simbulo && m1.Arry[3] == cruz.simbulo && m1.Arry[6] == cruz.simbulo){
            ver.vic(cruz);
            vitoria = true;

          }else if(m1.Arry[2] == cruz.simbulo && m1.Arry[5] == cruz.simbulo && m1.Arry[8] == cruz.simbulo){
            ver.vic(cruz);
            vitoria = true;
          }  
        
        }
        public void SalvarEstatisticas(){
            estatisticasDoJogo = ObterEstatisticasDoJogo();
            estatis.SalvarEstatisticas(estatisticasDoJogo);
        }
        private int[] ObterEstatisticasDoJogo(){
            int[] estatisticas = new int[2];
            estatisticas[0] = p1.ContarVitorias();
            estatisticas[1] = p2.ContarVitorias();
            return estatisticas;
        }

    }
}