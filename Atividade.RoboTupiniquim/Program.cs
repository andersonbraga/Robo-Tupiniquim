namespace Atividade.RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {


            char quantidadeRobo;
            do
            {
                Console.Write("Insira a posicao Inicial do Robo x: ");
                int posicaoInicialX = Convert.ToInt32(Console.ReadLine().ToUpper());

                Console.Write("Insira a posicao Inicial do Robo y: ");
                int posicaoInicialY = Convert.ToInt32(Console.ReadLine().ToUpper());

                Console.WriteLine("Insira a direção do Robo: (N), (S), (L), (O) ");
                char direcao = Convert.ToChar(Console.ReadLine().ToUpper());

                Console.Write("Insira o camando a ser executado: ");
                string comando = Console.ReadLine().ToUpper();

                char[] charComando = comando.ToCharArray();
                
                int posicaoFinalX = posicaoInicialX;
                int posicaoFinalY = posicaoInicialY; ;
                for (int i = 0; i < charComando.Length; i++)
                {
                    if (charComando[i] == 'M')
                    {
                        if (direcao == 'N')
                        {
                            posicaoFinalY++;
                        }
                        else if (direcao == 'S')
                        {
                            posicaoFinalY--;
                        }
                        else if (direcao == 'L')
                        {
                            posicaoFinalX++;
                        }
                        else if (direcao == 'O')
                        {
                            posicaoFinalX--;
                        }

                    }

                    else if (charComando[i] == 'E')
                    {
                        if (direcao == 'N')
                        {
                            direcao = 'L';
                        }

                        else if (direcao == 'S')
                        {
                            direcao = 'O';
                        }



                        else if (direcao == 'L')
                        {
                            direcao = 'S';
                        }

                        else if (direcao == 'O')
                        {
                            direcao = 'N';
                        }
                    }

                    else if (charComando[i] == 'D')
                    {
                        if (direcao == 'S')
                        {
                            direcao = 'O';
                        }
                        else if (direcao == 'N')
                        {
                            direcao = 'L';
                        }
                        else if (direcao == 'O')
                        {
                            direcao = 'N';
                        }

                        else if (direcao == 'L')
                        {
                            direcao = 'S';
                        }
                    }

                }
                Console.WriteLine($"{posicaoFinalX} {posicaoFinalY} {direcao}" );
                Console.WriteLine("Deseja insirar outro robo? (S) sim ou (N) não ");
                quantidadeRobo = Convert.ToChar(Console.ReadLine().ToUpper());
            } while (quantidadeRobo == 'S');
        }
    }
}