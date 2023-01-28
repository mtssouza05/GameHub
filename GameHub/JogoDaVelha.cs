using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GameHub
{
    public class JogoDaVelha
    {
        public char[,] game = { { '-', '-', '-'},
                                { '-', '-', '-'},
                                { '-', '-', '-'} };


        public void ShowTable()
        {
            for(int i=0; i < 3; i++)
            {
                for(int j=0; j < 3; j++)
                {
                    Console.Write($"{game[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        public int Play1()
        {
            Console.WriteLine("Digite a linha destino: ");
            int linha = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a coluna destino: ");
            int coluna = int.Parse(Console.ReadLine());

            if (game[linha, coluna] == '-')
            {
                game[linha, coluna] = 'x';


                if (game[linha, 0] == 'x' && game[linha, 1] == 'x' && game[linha, 2] == 'x')
                    return 3;

                else if (game[0, 0] == 'x' && game[1, 1] == 'x' && game[2, 2] == 'x')
                    return 3;

                else if (game[0, 2] == 'x' && game[1, 1] == 'x' && game[2, 0] == 'x')
                    return 3;

                else if (game[0, coluna] == 'x' && game[1, coluna] == 'x' && game[2, coluna] == 'x')
                    return 3;
                else
                {
                    int cont = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (game[i, j] == '-')
                            {
                                cont = 1;
                            }
                        }
                    }
                    if (cont == 1)
                    {
                        return 1;
                    }
                    else
                        return 4;
                }

            }
            else
                return 2;
                

        }



        public int Play2()
        {
            Console.WriteLine("Digite a linha destino: ");
            int linha = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a coluna destino: ");
            int coluna = int.Parse(Console.ReadLine());

            if (game[linha, coluna] == '-')
            {
                game[linha, coluna] = 'o';


                if (game[linha, 0] == 'o' && game[linha, 1] == 'o' && game[linha, 2] == 'o')
                    return 3;

                else if (game[0, 0] == 'o' && game[1, 1] == 'o' && game[2, 2] == 'o')
                    return 3;

                else if (game[0, 2] == 'o' && game[1, 1] == 'o' && game[2, 0] == 'o')
                    return 3;

                else if (game[0, coluna] == 'o' && game[1, coluna] == 'o' && game[2, coluna] == 'o')
                    return 3;
                else
                {
                    int cont = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (game[i, j] == '-')
                            {
                                cont = 1;
                            }
                        }
                    }
                    if (cont == 1)
                    {
                        return 1;
                    }
                    else
                        return 4;
                }

            }
            else
                return 2;


        }

        public void Save(string? name, int point)
        {
            Player player = new Player { Name = name, Points = point };
            string json = JsonConvert.SerializeObject(player);
            File.WriteAllText(@"C:\Users\matth\source\repos\GameHub", json);
        }

        public void ShowJson()
        {
            string showjson = File.ReadAllText(@"C:\Users\matth\source\repos\GameHub\GameHub");
            var playerjson = JsonConvert.DeserializeObject<Player>(showjson);
            Console.WriteLine($"Nome: {playerjson.Name} || Pontuação: {playerjson.Points}");
        }

    }
}


// 1 - Jogada funcionou, jogo rodando
// 2 - Jogada impossível
// 3 - Jogada Ponto, jogo finalizado
// 4 - Deu velha