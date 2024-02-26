using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgramTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string inputPlayer, inputCPU;
            int randomInt;

            //BOOL voorwaarde start loop
            bool restartGame = true;


            while (restartGame)
            {
                //SCORE
                int scorePlayer = 0;
                int scoreCPU = 0;
                //LOOP
                while (scorePlayer < 3 && scoreCPU < 3)
                {



                    Console.WriteLine("Choose between ROCK, PAPER OR SCISSORS:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        //Verschillende acties vanuit random selectie CPU
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("PC Chose ROCK!");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW\n\n");
                            }

                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS! \n\n");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PC WINS!\n\n");
                                scoreCPU++;
                            }
                            break;

                        case 2:
                            inputCPU = "PAPER";
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PC WINS!\n\n");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW\n\n");
                            }

                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PC WINS\n\n");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW\n\n");
                            }
                            break;
                        default:
                            Console.WriteLine("MISMATCH!");

                            break;
                    }

                    if (scorePlayer == 3)
                    {
                        Console.WriteLine("Player has won!");
                    }
                    else
                    {
                        if (scoreCPU == 3)
                        {
                            Console.WriteLine("PC HAS WON!");
                        }

                        else
                        {
                            //Geen else actie toegevoegd
                        }
                        Console.WriteLine("Do you want to play again?(y/n)");
                        string loop = Console.ReadLine();
                        if (loop == "y")
                        {
                            restartGame = true;

                        }
                        else if (loop == "n")
                        {
                            restartGame = false;
                        }
                        else
                        {
                            //Geen else actie toegevoegd
                        }
                    }




                }
            }
        }
    }
}

