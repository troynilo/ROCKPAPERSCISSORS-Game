using System;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string  pInput, CPUinput;
            int randomInt;
            bool pAns = true;

            while (pAns == true)
            {
                int cpuScore = 0;
                int playerScore = 0;




                while (playerScore < 3 && cpuScore < 3)
                {
                    Console.WriteLine("Choose between Rock, Paper or Scissor:       Player:" + playerScore + "     CPU:" + cpuScore);
                    pInput = Console.ReadLine();
                    pInput = pInput.ToUpper();


                    Random rmd = new Random();

                    randomInt = rmd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            CPUinput = "ROCK";
                            Console.WriteLine("CPU pick:  ROCK");
                            if (pInput == "ROCK")
                            {
                                Console.WriteLine("DRAW!!");
                            }

                            if (pInput == "PAPER")
                            {
                                Console.WriteLine("Player Win!!");
                                playerScore++;
                            }
                            if (pInput == "SCISSOR")
                            {
                                Console.WriteLine("CPU WIn!!");
                                cpuScore++;
                            }
                            break;
                        case 2:
                            CPUinput = "Paper";
                            Console.WriteLine("CPU pick: PAPER");
                            if (pInput == "PAPER")
                            {
                                Console.WriteLine("DRAW!!");
                            }
                            if (pInput == "ROCK")
                            {
                                Console.WriteLine("CPU Win!!");
                                cpuScore++;
                            }
                            if (pInput == "SCISSOR")
                            {
                                Console.WriteLine("Player Win!!");
                                playerScore++;
                            }
                            break;
                        case 3:
                            CPUinput = "Scissor";
                            Console.WriteLine("CPU pick : SCISSOR");
                            if (pInput == "SCISSOR")
                            {
                                Console.WriteLine("DRAW!!");
                            }
                            if (pInput == "ROCK")
                            {
                                Console.WriteLine("Player Win!!");
                                playerScore++;
                            }
                            if (pInput == "PAPER")
                            {
                                Console.WriteLine("CPU Win!!");
                                cpuScore++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    }
                }
                if (playerScore == 3)
                {
                    Console.WriteLine("You Won!!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (cpuScore == 3)
                {
                    Console.WriteLine("CPU Won!! Better luck next time");
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.WriteLine("Do you want to play again? y/n");
                string Ans = Console.ReadLine();
                Ans = Ans.ToUpper();

                if (Ans == "Y")
                {
                    pAns = true;
                }
                else if (Ans== "N")
                {
                    Console.WriteLine("Press any key to quit");
                }
          }
            Console.ReadLine();
        }
    }
}
