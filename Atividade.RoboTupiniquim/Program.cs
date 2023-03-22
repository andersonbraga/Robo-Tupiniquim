namespace Atividade.RoboTupiniquim
{

    static internal class Program
    {
        static string comando;
        static char[] charComando;
        static int posicaoInicialX;
        static int posicaoInicialY;
        static char direcao;
        static int posicaoFinalX;
        static int posicaoFinalY;

        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                PosicaoInicial();
                Comandos();
            }
        }

        



        public static void PosicaoInicial()
      
        {
            Console.Write("Insira a posicao Inicial do Robo x: ");
            posicaoInicialX = Convert.ToInt32(Console.ReadLine().ToUpper());

            Console.Write("Insira a posicao Inicial do Robo y: ");
            posicaoInicialY = Convert.ToInt32(Console.ReadLine().ToUpper());

            Console.WriteLine("Insira a direção do Robo: (N), (S), (L), (O) ");
            direcao = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.Write("Insira o camando a ser executado: ");
            comando = Console.ReadLine().ToUpper();

            charComando = comando.ToCharArray();

            posicaoFinalX = posicaoInicialX;
            posicaoFinalY = posicaoInicialY;
        }

        public static void Comandos()
        {
            
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
            Console.WriteLine($"{posicaoFinalX} {posicaoFinalY} {direcao}");
            
           

        }
    }
}