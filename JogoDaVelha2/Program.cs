using System;

namespace JogoDaVelha2
{
    internal class Program
    {
        static string jogo, nome1, nome2, numero = "0", qlqr;
        static string[] colunas = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static int vez = 1, colunasP;
        static int numeroint;
        static bool venceu;
        static void Main()
        {
            Console.WriteLine("Escrevam seus nomes.\n");
            Console.WriteLine("Primeiro Jogador:");
            nome1 = Console.ReadLine();
            Console.WriteLine("\nSegundo jogador:");
            nome2 = Console.ReadLine();
            Console.WriteLine();
            ExibirJogo();
            VerificarSeletor();
        }
        static void ExibirJogo()
        {
            Console.Clear();
            if(vez == 1)
            {
                Console.WriteLine("Vez de: " + nome1 + "\n");
            }
            else if (vez == 2)
            {
                Console.WriteLine("Vez de: " + nome2 + "\n");
            }
            jogo = "_" + colunas[0] + "_|_" + colunas[1] + "_|_" + colunas[2] + "_\n" +
                   "_" + colunas[3] + "_|_" + colunas[4] + "_|_" + colunas[5] + "_\n " +
                         colunas[6] + " | " + colunas[7] + " | " + colunas[8];
            Console.WriteLine(jogo);
            VerificarJogo();
        }
        static void VerificarJogo()
        {
            if(colunas[0] == "X" && colunas[1] == "X" && colunas[2] == "X" ||
               colunas[3] == "X" && colunas[4] == "X" && colunas[5] == "X" ||
               colunas[6] == "X" && colunas[7] == "X" && colunas[8] == "X" ||

               colunas[0] == "X" && colunas[3] == "X" && colunas[6] == "X" ||
               colunas[1] == "X" && colunas[4] == "X" && colunas[7] == "X" ||
               colunas[2] == "X" && colunas[5] == "X" && colunas[8] == "X" ||

               colunas[0] == "X" && colunas[4] == "X" && colunas[8] == "X" ||
               colunas[2] == "X" && colunas[4] == "X" && colunas[6] == "X")
            {
                Console.WriteLine("Jogador " + nome1 + " Ganhou o jogo!");
                venceu = true;
                Reiniciar();
            }
            else if(colunas[0] == "O" && colunas[1] == "O" && colunas[2] == "O" ||
                    colunas[3] == "O" && colunas[4] == "O" && colunas[5] == "O" ||
                    colunas[6] == "O" && colunas[7] == "O" && colunas[8] == "O" ||

                    colunas[0] == "O" && colunas[3] == "O" && colunas[6] == "O" ||
                    colunas[1] == "O" && colunas[4] == "O" && colunas[7] == "O" ||
                    colunas[2] == "O" && colunas[5] == "O" && colunas[8] == "O" ||

                    colunas[0] == "O" && colunas[4] == "O" && colunas[8] == "O" ||
                    colunas[2] == "O" && colunas[4] == "O" && colunas[6] == "O")
            {
                Console.WriteLine("Jogador " + nome2 + " Ganhou o jogo!");
                venceu = true;
                Reiniciar();
            }
            if(venceu == false && colunasP == 9)
            {
                Console.WriteLine("Empate!");
                Reiniciar();
            }
        }
        static void VerificarSeletor()
        {
            numero = Console.ReadLine();
            for(int i = 0; i < colunas.Length; i++)
            {
                if(numero == colunas[i] && vez == 1 && colunas[i] != "X" && colunas[i] != "O")
                {
                    colunas[i] = "X";
                    numeroint = Int32.Parse(numero);
                    vez = 2;
                    colunasP++;
                }
                else if(numero == colunas[i] && vez == 2 && colunas[i] != "X" && colunas[i] != "O")
                {
                    colunas[i] = "O";
                    numeroint = Int32.Parse(numero);
                    vez = 1;
                    colunasP++;
                }
            }
            if(numeroint == 0)
            {
                VerificarSeletor();
            }
            else
            {
                ExibirJogo();
                VerificarSeletor();
                numeroint = 0;
            }
        }
        static void Reiniciar()
        {
            Console.WriteLine("Escreva qualquer coisa pra reiniciar a partida");
            qlqr = Console.ReadLine();
            venceu = false;
            colunasP = 0;
            colunas = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            vez = 1;
            ExibirJogo();
        }
    }
}