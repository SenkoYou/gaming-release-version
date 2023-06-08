using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace gaming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human game = new Human();
            Human gg = game.newGG();

            Console.WriteLine(" Вы заходите в подземелье. Тут так воняет, что вы сразу понимаете - оно кишит врагами. \n Но, в этом есть и плюсы, ведь в нем явно могут быть сокровища, а у вас кредит и ипотека! \n Посмотрите на ваши статы и сделайте выбор! \n");
            gg.getInfo();
            Console.WriteLine(" Решаетесь исследовать подземелье? (y/n)\n ");
            string YorN = Console.ReadLine();
            Console.WriteLine("");

            if (YorN == "y" || YorN == "n")
            {

                if (YorN == "n")
                {
                    gg.stayAlive = false;
                    Console.WriteLine(" Вы решаете, что лучше начать работать, а не лазить по подземельям");

                }
            }
            else
            {
                gg.stayAlive = false;
                Console.WriteLine(" Если вы не можете попасть по буквам, то вам явно не место тут");
            }

            while (gg.stayAlive)
            {
                Random random = new Random();
                int chance = random.Next(1, 10);
                if (chance == 9 || chance == 3)
                {
                    gg = game.fight(gg);
                    game.WinOrLoose(gg);
                }
                else
                {
                    game.gameEnd(gg,3);
                    gg.successGo();

                }

                Console.WriteLine("\n Идти дальше?(y/n)\n Вы также можете вывести ваши статы:(s)\n");
                string input = Console.ReadLine();
                Console.WriteLine("");
                if (input == "s") {
                    gg.getInfo();
                    Console.WriteLine("\n Идти дальше?(y/n)\n");
                    input = Console.ReadLine();
                    Console.WriteLine("");
                }
                if (input == "y" || input == "n")
                {
                    if (input == "y")
                    {
                        Console.WriteLine("\n Вы идете дальше... \n");

                    } else
                    {
                        Console.WriteLine("\n Как жаль, что ваше приключение так быстро подошло к концу...");
                        break;
                    }
                } else
                {
                    Console.WriteLine("\n Не понял, что вы имели ввиду, но наверное вы хотели идти дальше");
                }


            }
        }

    }
}

               