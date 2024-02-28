using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace JogodoGalo
{
    public class Controla
    {  
      public Player p1;
      public Player p2;
      public Papel m1;
      public Estatisticas estatis;
      int escolha; // Antes era para escolher se queira sair, estatisticas ou jogar as vitorias estão a dar certo mas o empate não está a aparecer mais a mensagem antes aparecia sempre que algem jogava então mudei mas não ficou bom e mesmo tentando de tudo não deram certo as estatisticas
      bool p;
      bool vitoria  = false;
      public int[] ficheiro = new int[88888]; 
      int[] estatisticasDoJogo = new int[5];
      
      private static string caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
      , "estatisticas.txt");


        public Controla(Player[] jogador, Papel papel,Estatisticas estitis){
          p1 = jogador[0];
          p2 = jogador[1];
          m1 = papel;
          estatis = estitis;
        }
        public void Iniciar(View ver){
           if(File.Exists(caminho)){
            StreamReader sr = new StreamReader(caminho);
            for(int i =0 ; i < estatisticasDoJogo.Length; i++){
              estatisticasDoJogo[i] = Convert.ToInt32(sr.ReadLine());
            }
            sr.Close();
          }
          
          Menu(ver);
        }  

        public void Menu(View wer){
          p1.DefiNome(wer.Nome());
          p2.DefiNome(wer.Nome());

          do{
            int j = wer.Escolha();
            if(j == 1){
              p = true;
              Jogo(wer);              
            }else if(j == 2){
              p = true;
              wer.MostraEstatisticas(estatisticasDoJogo);  
            }else if(j == 3){
              p = false;
            }else{
              p = false;
              wer.Falso();
            }
          }while(!p);


        }
        public void Jogo(View ver){
          int registo = 1;
          bool boliana = false;
          bool cheio = false;
          p  = false;

          m1.Limpa();
          while(!vitoria && !cheio){
          ver.Mostra(m1);
          int pega = ver.Joge(registo == 1? p1:p2);
          boliana = m1.jogada(pega,registo == 1? p1:p2);
          ver.Mostra(m1);
          cheio = m1.comparar(ver);
          Victory(registo == 1? p1:p2, ver, m1);

            if(boliana == true){
              if(registo == 2){
                registo = 1;
                ver.gamede(p1);
                estatisticasDoJogo[2]++;
              }else{
                registo = 2;
                ver.gamede(p2);
                estatisticasDoJogo[3]++;
              }
            }
          }
          cheio = m1.comparar(ver);

          if(vitoria){
            if(registo == 2){
              estatisticasDoJogo[0]++;
            }else if(registo == 1){
              estatisticasDoJogo[1]++;
            }
          }
          if(cheio){
            estatisticasDoJogo[4]++;
            if(!vitoria){
             ver.Empate();
            }
           
          }
          estatis.SalvarEstatisticas(estatisticasDoJogo, caminho);
          Menu(ver);
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
            estatis.SalvarEstatisticas(estatisticasDoJogo,caminho);
        }
        private int[] ObterEstatisticasDoJogo(){
            int[] estatisticas = new int[2];
            estatisticas[0] = p1.ContarVitorias();
            estatisticas[1] = p2.ContarVitorias();
            return estatisticas;
        }

    }
}