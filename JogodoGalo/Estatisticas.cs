using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace JogodoGalo
{

    public class Estatisticas
    {
        /*public void ContarVitorias(Player jogador){
            int[] estatisticas = LerEstatisticas();

            if (jogador != null){
                int indiceJogador = jogador.Equals(jogador) ? 0 : 0;

                estatisticas[indiceJogador]++;
            }
            SalvarEstatisticas(estatisticas);
        }*/

        public int[] LerEstatisticas(){
            FileStream ficha = new FileStream("estatistica.txt",FileMode.Create);
            string[] linhas = File.ReadAllLines("estatistica.txt");
            int[] estatisticas = new int[linhas.Length];

            for (int i = 0; i < linhas.Length; i++)
            {
                if (int.TryParse(linhas[i],out int valor))
                {
                    estatisticas[i] = valor;
                }
            }

            return estatisticas;
        }

        public void SalvarEstatisticas(int[] estatisticas, string caminho)
        {
            using (StreamWriter escreve = new StreamWriter(caminho))
            {
                foreach (int est in estatisticas)
                {
                    escreve.WriteLine(est);
                }
            }
        }
        public void SalvarEstatisticasNoArquivo(int[] estatisticas){
            using(StreamWriter escreve = new StreamWriter("estatistica.txt")){
                foreach(int est in estatisticas){
                    escreve.WriteLine(est);
                }
            }
        }
    }
}


