using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub
{
    public class BatalhaNaval
    {
        public char[,] GameTable1 = { { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' } };

        public char[,] GameTable2 = { { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' },
                                      { '-', '-', '-', '-', '-', '-', '-', '-' } };


        public void PutLocalBoat(int number)
        {
            char posicao = '-';
            int linha = 0, coluna = 0;
            try
            {
                Console.WriteLine("Escolha a linha que deseja colocar o navio: ");
                linha = int.Parse(Console.ReadLine());

                Console.WriteLine("Escolha a coluna: ");
                coluna = int.Parse(Console.ReadLine());

                Console.WriteLine("Escolha se deseja se o navio deve ficar na horizontal(h para horizontal) ou vertical(v para vertical): ");
                posicao = char.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Algum valor inseriodo está incorreto, por favor siga as instruções para o jogo poder funcionar");
            }
            

            if (number == 1)
            {
                if (posicao == 'h')
                {
                    if (coluna <= 3)
                    {
                        GameTable1[linha, 3] = 'B';
                        GameTable1[linha, 2] = 'O';
                        GameTable1[linha, 1] = 'A';
                        GameTable1[linha, 0] = 'T';

                    }
                    else
                    {
                        GameTable1[linha, 7] = 'B';
                        GameTable1[linha, 6] = 'O';
                        GameTable1[linha, 5] = 'A';
                        GameTable1[linha, 4] = 'T';
                    }

                }
                else
                {
                    if (linha <= 3)
                    {
                        GameTable1[3, coluna] = 'B';
                        GameTable1[2, coluna] = 'O';
                        GameTable1[1, coluna] = 'A';
                        GameTable1[0, coluna] = 'T';
                    }
                    else
                    {
                        GameTable1[7, coluna] = 'B';
                        GameTable1[6, coluna] = 'O';
                        GameTable1[5, coluna] = 'A';
                        GameTable1[4, coluna] = 'T';
                    }

                }

            }

            if (number == 2)
            {
                if (posicao == 'h')
                {
                    if (coluna <= 3)
                    {
                        GameTable2[linha, 3] = 'B';
                        GameTable2[linha, 2] = 'O';
                        GameTable2[linha, 1] = 'A';
                        GameTable2[linha, 0] = 'T';

                    }
                    else
                    {
                        GameTable2[linha, 7] = 'B';
                        GameTable2[linha, 6] = 'O';
                        GameTable2[linha, 5] = 'A';
                        GameTable2[linha, 4] = 'T';
                    }

                }
                else
                {
                    if (linha <= 3)
                    {
                        GameTable2[3, coluna] = 'B';
                        GameTable2[2, coluna] = 'O';
                        GameTable2[1, coluna] = 'A';
                        GameTable2[0, coluna] = 'T';
                    }
                    else
                    {
                        GameTable2[7, coluna] = 'B';
                        GameTable2[6, coluna] = 'O';
                        GameTable2[5, coluna] = 'A';
                        GameTable2[4, coluna] = 'T';
                    }

                }
            }

        }

        public void Play(int number)
        {
            int linhaBomba = 0, colunaBomba = 0;
            try
            {
                Console.WriteLine("Passe agora as coordenadas de onde deseja bombardear: ");
                Console.WriteLine("Insira a linha: ");
                linhaBomba = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira a coluna: ");
                colunaBomba = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Algum valor inseriodo está incorreto, por favor siga as instruções para o jogo poder funcionar");
            }

            if (number == 1)
            {
                if(GameTable2[linhaBomba, colunaBomba] != '-')
                {
                    Console.WriteLine("Acertou uma parte do Navio !");
                    GameTable2[linhaBomba, colunaBomba] = '*';
                }
                else
                    Console.WriteLine("Nada foi atingido !");
            }

            else if (number == 2)
            {
                if (GameTable1[linhaBomba, colunaBomba] != '-')
                {
                    Console.WriteLine("Acertou uma parte do Navio !");
                    GameTable1[linhaBomba, colunaBomba] = '*';
                }
                else
                    Console.WriteLine("Nada foi atingido !");
            }
            
        }
    }
}

// TODO 
// Tentar colocar as funções em prática e checar se estão funcionandp
// se não  estiverem, procurar e tratar erros, se sim, finalizar e lapidar todo o projeto