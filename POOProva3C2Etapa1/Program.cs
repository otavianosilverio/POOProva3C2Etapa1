using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOProva3C2Etapa1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Resolução da Prova Tipo A
            // Time de Futebol
            //////////////////////////////////////
            Random random = new Random();
            int[] VetorTime = new int[11];

            int media_numeros = 0, soma_numeros = 0, MaiorGols = 0, PosicaoArtilheiro=0;

            for (int i = 0; i < 11; i++)
            {
                VetorTime[i] = random.Next(0, 20);
                soma_numeros = soma_numeros + VetorTime[i];
                // Identificando o Artilheio e sua posição
                if (VetorTime[i] > MaiorGols)
                {
                    MaiorGols = VetorTime[i];
                    PosicaoArtilheiro = i;
                }

                Console.WriteLine("VetorTime -> " + i + " - " + VetorTime[i] + "\t");
            }
            media_numeros = (soma_numeros / 11);
            Console.WriteLine("A média de gols da equipe é -> " + media_numeros + "\t");

            Console.WriteLine("O maior número de gols é " + MaiorGols + " e o artilheiro está na posição " + PosicaoArtilheiro + " do VetorTime \n");
            Console.ReadKey();

            //// 
            ///// Resolução da Prova Tipo B
            //////////////////////////////////////

            int[] q2_xx = new int[11];

            media_numeros = 0;
            soma_numeros = 0;
            int qtde_abaixoMedia = 0;

            for (int i = 0; i < 11; i++)
            {
                q2_xx[i] = random.Next(0, 100);
                soma_numeros = soma_numeros + q2_xx[i];

                Console.WriteLine("Q2_xx -> " + i + " - " + q2_xx[i] + "\t");
            }
            media_numeros = (soma_numeros / 10);
            Console.WriteLine("A média é igual -> " + media_numeros + "\t");
            // Verificando numeros menores que a média
            for (int i = 0; i < 10; i++)
            {
                // Verificando se  a média.
                if (q2_xx[i] < media_numeros)
                {
                    qtde_abaixoMedia = qtde_abaixoMedia + 1;
                    Console.WriteLine("Número Abaixo da Médida -> " + q2_xx[i] + "\t");
                }


            }

            Console.WriteLine("Qtde de Números Abaixo da Média -> " + qtde_abaixoMedia + "\n");
            Console.ReadKey();


        }
    }
}
