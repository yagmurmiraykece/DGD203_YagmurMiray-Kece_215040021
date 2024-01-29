using System;

namespace DGD203
{
    internal class TheGame
    {
        private static string _playerName;
        private static int _playerPosition = 0;
        private const int MapSize = 10;

        private static void Main()
        {
            Console.Write("\r\n░█████╗░░█████╗░██████╗░██████╗░██╗██████╗░░█████╗░██████╗░\r\n██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗██╔══██╗██╔══██╗\r\n██║░░╚═╝██║░░██║██████╔╝██████╔╝██║██║░░██║██║░░██║██████╔╝\r\n██║░░██╗██║░░██║██╔══██╗██╔══██╗██║██║░░██║██║░░██║██╔══██╗\r\n╚█████╔╝╚█████╔╝██║░░██║██║░░██║██║██████╔╝╚█████╔╝██║░░██║\r\n░╚════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.Write("\nHello my little fellove,");
            Console.Write("\nWelcome to my game...");
            Console.Write("\nBut first, who are you..? ");
            _playerName = Console.ReadLine();

            if (_playerName == "onur")
            {
                Console.WriteLine($"\nH-Hocam! *önünü ilikler* oynayalım hocam buyrun ehe");
            }
            else
            {
                Console.WriteLine($"\nIt's a pleasure to meet you, {_playerName}. Welcome to my game...");
            }

            Console.WriteLine("\nAnyway, let's begin....");
            Console.WriteLine("\nWe will pass through a narrow corridor together.");
            Console.WriteLine("\nDo not scare, I know you are a brave soul.");
            Console.WriteLine("\nBut still, you can quit anytime you want.");

            string[][] steps = new string[][]
            {
                new string[] { "Now my dear, we are here.", "We're right in front of the hallway. Follow me...", "Want to continue our journey?", "1. We just started!", "2. I'm sorry, good bye..." },
                new string[] { "You are very brave, i'm so proud...", "Keep following me...", "Ready to proceed?", "1. Easy-Peasy!", "2. I'm done, I want to quit..." },
                new string[] { "I know there are some voices but do not mind them.", "They come and go...", "Come on...", "1. I'm... coming...", "2. I've had enough. I quit..." },
            };

            foreach (string[] step in steps)
            {
                Console.WriteLine(step[0]);
                Console.WriteLine(step[1]);

                Console.WriteLine(step[2]);
                Console.WriteLine(step[3]);
                Console.WriteLine(step[4]);

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _playerPosition++; 
                        break;
                    case "2":
                        Console.WriteLine("Quitting game...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please choose again.");
                        break;
                }
            }

            Console.WriteLine("\nBefore you continue, a soul with scars stops you. \nIt looks like it has some questions for you. \nAnswer correctly, or...");

            string[] questions = { "What is more important for a broken soul?", "What is 2+2?", "What is the answer to life, the universe, and everything?" };
            string[] answers = { "Love", "4", "42" };

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"\nSoul: {questions[i]}");
                Console.Write("Your answer: ");
                string playerAnswer = Console.ReadLine();

                if (playerAnswer.ToLower() == answers[i].ToLower())
                {
                    Console.WriteLine("Soul: Woaw, I wasn't expecting that. \nSo I won't stop you here.");
                    Console.WriteLine("\nSoul: Here, you can continue... but don't listen to him...");
                }
                else
                {
                    Console.WriteLine("Soul: Luckily, you didn't give me the right answer. \nThink like I saved you.");
                    Console.WriteLine("\n\r\n▒█▀▀▄ █▀▀█ █▀▀▄ █ ▀▀█▀▀ 　 █▀▀ █▀▀█ █▀▄▀█ █▀▀ 　 █▀▀▄ █▀▀█ █▀▀ █░█ ░ \r\n▒█░▒█ █░░█ █░░█ ░ ░░█░░ 　 █░░ █░░█ █░▀░█ █▀▀ 　 █▀▀▄ █▄▄█ █░░ █▀▄ ▄ \r\n▒█▄▄▀ ▀▀▀▀ ▀░░▀ ░ ░░▀░░ 　 ▀▀▀ ▀▀▀▀ ▀░░░▀ ▀▀▀ 　 ▀▀▀░ ▀░░▀ ▀▀▀ ▀░▀ █");
                    return;
                }
            }

            Console.WriteLine("\nSoul: You've answered all questions correctly!");
            Console.WriteLine("Soul: I'll allow you to proceed. Beware of what lies ahead...");

            Console.WriteLine("\nAhem... Great job. I think we can continue now...");

            Console.WriteLine("\nYou are here... \n...right?");
            Console.WriteLine("1. Still here.");
            Console.WriteLine("2. ...");

            string finalChoice = Console.ReadLine();

            switch (finalChoice)
            {
                case "1":
                    Console.WriteLine("\nGreat! Ah, you scared me for a moment...");
                    break;
                case "2":
                    Console.WriteLine("\nQuitting game...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Quitting game...");
                    return;
            }

            string[][] additionalSteps = new string[][]
             {
                new string[] { "Come on!", "We're almost there...", "1. Coming!", "2. I don't want to..." },
                new string[] { "So close... Come on...", "I'll wait until you feel ready.", "\r\n██████╗░░█████╗░███╗░░██╗██╗████████╗  ██╗░░██╗███████╗███████╗██████╗░  ███╗░░░███╗███████╗\r\n██╔══██╗██╔══██╗████╗░██║╚█║╚══██╔══╝  ██║░██╔╝██╔════╝██╔════╝██╔══██╗  ████╗░████║██╔════╝\r\n██║░░██║██║░░██║██╔██╗██║░╚╝░░░██║░░░  █████═╝░█████╗░░█████╗░░██████╔╝  ██╔████╔██║█████╗░░\r\n██║░░██║██║░░██║██║╚████║░░░░░░██║░░░  ██╔═██╗░██╔══╝░░██╔══╝░░██╔═══╝░  ██║╚██╔╝██║██╔══╝░░\r\n██████╔╝╚█████╔╝██║░╚███║░░░░░░██║░░░  ██║░╚██╗███████╗███████╗██║░░░░░  ██║░╚═╝░██║███████╗\r\n╚═════╝░░╚════╝░╚═╝░░╚══╝░░░░░░╚═╝░░░  ╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░░░░  ╚═╝░░░░░╚═╝╚══════╝\r\n\r\n░██╗░░░░░░░██╗░█████╗░██╗████████╗██╗███╗░░██╗░██████╗░  ███████╗██████╗░███████╗░█████╗░██╗░░██╗\r\n░██║░░██╗░░██║██╔══██╗██║╚══██╔══╝██║████╗░██║██╔════╝░  ██╔════╝██╔══██╗██╔════╝██╔══██╗██║░██╔╝\r\n░╚██╗████╗██╔╝███████║██║░░░██║░░░██║██╔██╗██║██║░░██╗░  █████╗░░██████╔╝█████╗░░███████║█████═╝░\r\n░░████╔═████║░██╔══██║██║░░░██║░░░██║██║╚████║██║░░╚██╗  ██╔══╝░░██╔══██╗██╔══╝░░██╔══██║██╔═██╗░\r\n░░╚██╔╝░╚██╔╝░██║░░██║██║░░░██║░░░██║██║░╚███║╚██████╔╝  ██║░░░░░██║░░██║███████╗██║░░██║██║░╚██╗\r\n░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝╚═╝░░░╚═╝░░░╚═╝╚═╝░░╚══╝░╚═════╝░  ╚═╝░░░░░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝", "1. I... won't..?", "2. You'll wait forever." },
                new string[] { "\r\n██╗░░░░░░█████╗░░██████╗████████╗  ░██████╗████████╗███████╗██████╗░\r\n██║░░░░░██╔══██╗██╔════╝╚══██╔══╝  ██╔════╝╚══██╔══╝██╔════╝██╔══██╗\r\n██║░░░░░███████║╚█████╗░░░░██║░░░  ╚█████╗░░░░██║░░░█████╗░░██████╔╝\r\n██║░░░░░██╔══██║░╚═══██╗░░░██║░░░  ░╚═══██╗░░░██║░░░██╔══╝░░██╔═══╝░\r\n███████╗██║░░██║██████╔╝░░░██║░░░  ██████╔╝░░░██║░░░███████╗██║░░░░░\r\n╚══════╝╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░  ╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░", "\r\n██╗░░░░░░█████╗░░██████╗████████╗  ░██████╗████████╗███████╗██████╗░\r\n██║░░░░░██╔══██╗██╔════╝╚══██╔══╝  ██╔════╝╚══██╔══╝██╔════╝██╔══██╗\r\n██║░░░░░███████║╚█████╗░░░░██║░░░  ╚█████╗░░░░██║░░░█████╗░░██████╔╝\r\n██║░░░░░██╔══██║░╚═══██╗░░░██║░░░  ░╚═══██╗░░░██║░░░██╔══╝░░██╔═══╝░\r\n███████╗██║░░██║██████╔╝░░░██║░░░  ██████╔╝░░░██║░░░███████╗██║░░░░░\r\n╚══════╝╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░  ╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░", "\r\n██╗░░░░░░█████╗░░██████╗████████╗  ░██████╗████████╗███████╗██████╗░\r\n██║░░░░░██╔══██╗██╔════╝╚══██╔══╝  ██╔════╝╚══██╔══╝██╔════╝██╔══██╗\r\n██║░░░░░███████║╚█████╗░░░░██║░░░  ╚█████╗░░░░██║░░░█████╗░░██████╔╝\r\n██║░░░░░██╔══██║░╚═══██╗░░░██║░░░  ░╚═══██╗░░░██║░░░██╔══╝░░██╔═══╝░\r\n███████╗██║░░██║██████╔╝░░░██║░░░  ██████╔╝░░░██║░░░███████╗██║░░░░░\r\n╚══════╝╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░  ╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░", "1. Last step.", "2. Last chance." },
             };

            foreach (string[] step in additionalSteps)
            {
                Console.WriteLine(step[0]);
                Console.WriteLine(step[1]);

                Console.WriteLine(step[2]);
                Console.WriteLine(step[3]);

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _playerPosition++;
                        break;
                    case "2":
                        Console.WriteLine("Quitting game...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please choose again.");
                        break;
                }
            }

            Console.WriteLine("\nLook! We did it!");
            Console.WriteLine("\nI knew you were brave enough..");
            Console.WriteLine("\n..to be my new victim.");
            Console.WriteLine("\n\r\n███╗░░██╗░█████╗░░██╗░░░░░░░██╗░░░  ██╗░░░██╗░█████╗░██╗░░░██╗  ░█████╗░██████╗░███████╗\r\n████╗░██║██╔══██╗░██║░░██╗░░██║░░░  ╚██╗░██╔╝██╔══██╗██║░░░██║  ██╔══██╗██╔══██╗██╔════╝\r\n██╔██╗██║██║░░██║░╚██╗████╗██╔╝░░░  ░╚████╔╝░██║░░██║██║░░░██║  ███████║██████╔╝█████╗░░\r\n██║╚████║██║░░██║░░████╔═████║░██╗  ░░╚██╔╝░░██║░░██║██║░░░██║  ██╔══██║██╔══██╗██╔══╝░░\r\n██║░╚███║╚█████╔╝░░╚██╔╝░╚██╔╝░╚█║  ░░░██║░░░╚█████╔╝╚██████╔╝  ██║░░██║██║░░██║███████╗\r\n╚═╝░░╚══╝░╚════╝░░░░╚═╝░░░╚═╝░░░╚╝  ░░░╚═╝░░░░╚════╝░░╚═════╝░  ╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝\r\n\r\n███╗░░░███╗██╗███╗░░██╗███████╗  ███████╗░█████╗░██████╗░███████╗██╗░░░██╗███████╗██████╗░░░░\r\n████╗░████║██║████╗░██║██╔════╝  ██╔════╝██╔══██╗██╔══██╗██╔════╝██║░░░██║██╔════╝██╔══██╗░░░\r\n██╔████╔██║██║██╔██╗██║█████╗░░  █████╗░░██║░░██║██████╔╝█████╗░░╚██╗░██╔╝█████╗░░██████╔╝░░░\r\n██║╚██╔╝██║██║██║╚████║██╔══╝░░  ██╔══╝░░██║░░██║██╔══██╗██╔══╝░░░╚████╔╝░██╔══╝░░██╔══██╗░░░\r\n██║░╚═╝░██║██║██║░╚███║███████╗  ██║░░░░░╚█████╔╝██║░░██║███████╗░░╚██╔╝░░███████╗██║░░██║██╗\r\n╚═╝░░░░░╚═╝╚═╝╚═╝░░╚══╝╚══════╝  ╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝");
            Console.WriteLine("\nSo here is the lesson we learn today.");
            Console.WriteLine("\n\r\n██████╗░░█████╗░  ███╗░░██╗░█████╗░████████╗  ████████╗██████╗░██╗░░░██╗░██████╗████████╗  ░█████╗░\r\n██╔══██╗██╔══██╗  ████╗░██║██╔══██╗╚══██╔══╝  ╚══██╔══╝██╔══██╗██║░░░██║██╔════╝╚══██╔══╝  ██╔══██╗\r\n██║░░██║██║░░██║  ██╔██╗██║██║░░██║░░░██║░░░  ░░░██║░░░██████╔╝██║░░░██║╚█████╗░░░░██║░░░  ███████║\r\n██║░░██║██║░░██║  ██║╚████║██║░░██║░░░██║░░░  ░░░██║░░░██╔══██╗██║░░░██║░╚═══██╗░░░██║░░░  ██╔══██║\r\n██████╔╝╚█████╔╝  ██║░╚███║╚█████╔╝░░░██║░░░  ░░░██║░░░██║░░██║╚██████╔╝██████╔╝░░░██║░░░  ██║░░██║\r\n╚═════╝░░╚════╝░  ╚═╝░░╚══╝░╚════╝░░░░╚═╝░░░  ░░░╚═╝░░░╚═╝░░╚═╝░╚═════╝░╚═════╝░░░░╚═╝░░░  ╚═╝░░╚═╝\r\n\r\n░██████╗████████╗██████╗░░█████╗░███╗░░██╗░██████╗░███████╗██████╗░░░░  ██╗░░██╗░█████╗░██╗░░██╗░█████╗░░░░\r\n██╔════╝╚══██╔══╝██╔══██╗██╔══██╗████╗░██║██╔════╝░██╔════╝██╔══██╗░░░  ██║░░██║██╔══██╗██║░░██║██╔══██╗░░░\r\n╚█████╗░░░░██║░░░██████╔╝███████║██╔██╗██║██║░░██╗░█████╗░░██████╔╝░░░  ███████║███████║███████║███████║░░░\r\n░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██║╚████║██║░░╚██╗██╔══╝░░██╔══██╗░░░  ██╔══██║██╔══██║██╔══██║██╔══██║░░░\r\n██████╔╝░░░██║░░░██║░░██║██║░░██║██║░╚███║╚██████╔╝███████╗██║░░██║██╗  ██║░░██║██║░░██║██║░░██║██║░░██║██╗\r\n╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝░╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝  ╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝");
            Console.WriteLine("\nSadly, you are not able to use that in your life.");
            Console.WriteLine("\nCause you don't have one.");
            Console.WriteLine("\n\r\n░██████╗██╗██╗░░██╗███████╗\r\n██╔════╝██║██║░██╔╝██╔════╝\r\n╚█████╗░██║█████═╝░█████╗░░\r\n░╚═══██╗██║██╔═██╗░██╔══╝░░\r\n██████╔╝██║██║░╚██╗███████╗\r\n╚═════╝░╚═╝╚═╝░░╚═╝╚══════╝");
        }

        private static void MoveForward()
        {
            _playerPosition++;
            if (_playerPosition >= MapSize)
            {
                _playerPosition = MapSize;
            }
        }
    }
}