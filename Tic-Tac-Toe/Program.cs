using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //create the playfield
        static char[,] playField =
            {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };

        static void Main(string[] args)
        {
            int player = 2; //player 1 starts
            int input = 0;
            bool inputCorrect = true;

            SetField();
            Console.ReadKey();

            do
            {
                if (player == 2)
                    player = 1;
                else if (player == 1)
                    player = 2;

                switch (player)
                {
                    //player 1's turn
                    case 1:
                }

            } while (true);
            {

            }


        }

        //create play field:
        public static void SetField()
        {
            Console.WriteLine("  | |    ");
            Console.WriteLine(" {0}|{1}|{2} ", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("-------");
            Console.WriteLine(" {0}|{1}|{2} ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("-------");
            Console.WriteLine(" {0}|{1}|{2} ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("  | |    ");
            

        }
    }
}
