using GameHub;
int aux = 0;
JogoDaVelha game = new();

while (true)
{
    Console.WriteLine("Digite o jogo que deseja jogar: \n"+
                       "1 - Jogo da velha\n"+ 
                       "2 - Batalha Naval\n"+
                       "3 - Mostrar jogadores");
    int op = int.Parse(Console.ReadLine());

    if (op == 1)
    {
        Console.WriteLine("Primeiro cadastre o jogador 1 ! \n"+
                          "Nome: ");
        string nome = Console.ReadLine();


        Console.WriteLine("Agora cadastre o jogador 2 ! \n" +
                          "Nome: ");
        string nome2 = Console.ReadLine();

        while (true)
        {

            for (int i = 1; i <= 2;)
            {
                Console.Clear();

                game.ShowTable();
                Console.WriteLine("Jogador 1 - x");
                if (i == 1)
                {
                    aux = game.Play1();

                    if (aux == 3)
                    {
                        Console.WriteLine("Jogador 1 ganhou !!");
                        game.ShowTable();
                        Console.ReadLine();
                        game.Save(nome, 1);
                        break;
                    }

                    else if (aux == 4)
                    {
                        Console.WriteLine("Deu velha :/");
                        game.ShowTable();
                        Console.ReadLine();
                        break;
                    }

                    else if (aux == 2)
                    {
                        Console.WriteLine("Jogada impossível, tente novamente");
                        Console.ReadLine();
                    }

                    else if (aux == 1)
                    {
                        Console.WriteLine("Jogada realizada");
                        Console.ReadLine();
                        i++;
                    }
                }

                else if(i == 2)
                {
                    Console.Clear();
                    game.ShowTable();
                    Console.WriteLine("Jogador 2 - o");
                    aux = game.Play2();

                    if (aux == 3)
                    {
                        Console.WriteLine("Jogador 2 ganhou !!");
                        game.ShowTable();
                        Console.ReadLine();
                        game.Save(nome2, 1);
                        break;
                    }

                    else if (aux == 4)
                    {
                        Console.WriteLine("Deu velha :/");
                        game.ShowTable();
                        Console.ReadLine();
                        break;
                    }

                    else if (aux == 2)
                    {
                        Console.WriteLine("Jogada impossível, tente novamente");
                    }

                    else if (aux == 1)
                    {
                        Console.WriteLine("Jogada realizada");
                        Console.ReadLine();
                        i++;
                    }
                }
            
            }

            if (aux == 3 || aux == 4)
                break;
        }
    }
    else if (op == 3)
    {
        try
        {
            game.ShowJson();
        }
        catch(Exception e)
        {
            Console.WriteLine("Nehum jogador ganhador foi registrado até o momento");
        }
    }
}
// 1 - Jogada funcionou, jogo rodando
// 2 - Jogada impossível
// 3 - Jogada Ponto, jogo finalizado
// 4 - Deu velha