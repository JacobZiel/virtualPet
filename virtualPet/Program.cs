using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace virtualPet
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Virtual Pet";
            int hp = 10;
            int food = 10;
            int sleep = 10;
            int count = 0;
            bool life = true;
            string[] names = {"Lean", "Carlos", "Ron", "Rayna", "Debera", "Anh", "Jarrett", "Cristopher", "Jenine", "Herma", "Shu", "Lincoln", "Alexa", "Mason", "Marna", "Shirlene", "Yukiko", "Eilene", "Georgi", "Connor", "Cammie", "Spring", "Neta", "Chanell", "Rea", "Andrea", "Truman", "Dan", "Ben", "Kyle", "Penelope", "Katie", "Jacob" };
            Random r = new Random();
            int n = r.Next(0, 32);
            string title = @"
                         Welcome to
   _   _           _                  _       ___          _   
  ( ) ( ) _       ( )_               (_ )    (  _`\       ( )_ 
  | | | |(_) _ __ | ,_) _   _    _ _  | |    | |_) )  __  | ,_)
  | | | || |( '__)| |  ( ) ( ) /'_` ) | |    | ,__/'/'__`\| |  
  | \_/ || || |   | |_ | (_) |( (_| | | |    | |   (  ___/| |_ 
  `\___/'(_)(_)   `\__)`\___/'`\__,_)(___)   (_)   `\____)`\__) v1.0 by JZ

                                                                 ";

            Console.WriteLine(title);
            Console.Beep(200, 100);
            Console.Beep(200, 100);
            Console.Beep(250, 100);
            Console.Beep(270, 200);
            Console.Beep(270, 100);
            Console.Beep(250, 100);
            Console.Beep(200, 100);
            Console.Beep(200, 200);
            Console.Beep(200, 100);
            Console.Beep(180, 200);
            Console.WriteLine("Name your virtual pet or type 1 for random name");
           
            var name = Console.ReadLine();
            var choosename = name;
            if(name == "1")
            {
                name = names[n];
            }
            else
            {
                name = choosename;
            }
            Console.Clear();
            string hedgTitle = $@"
                                  
    .|||||||||.                                          
   |||||||||||||                                                         
  |||||||||||' .\                                                   
  `||||||||||_,__o                   
______________________/\______/\______/\____/\______                 
       {name}   
                                                               ";
            Console.WriteLine(hedgTitle);
            Console.Beep(500, 100);
            Console.WriteLine(".");
            Console.WriteLine($"{name} health is {hp}, hunger is {food} and tiredness is {sleep}");
            Console.WriteLine(".");
            //call to main logic  
            Repeat(hp, food, sleep, name, count, life);
            Console.ReadKey();
        }
       

        public static void Repeat(int hp, int food, int sleep, string name, int count, bool life)
        {
            //suppose to be timer 
            var timer1 = new Timer(_ => Console.WriteLine(food--), null, 10000, 10000);
            var timer2 = new Timer(_ => sleep--, null, 10000, 10000);
            while (life == true)
            {
                if (food < 1)
                {

                    timer1.Change(Timeout.Infinite, Timeout.Infinite);
                    timer2.Change(Timeout.Infinite, Timeout.Infinite);
                    GameOver(name, count);
                    life = false;
                    
                }
                else
                {
                    while (food > 0 && sleep > 0)
                    {
                        Console.WriteLine($"1 for sleep, 2 for feed, 3 for stats or 4 for to clear the console |health is {hp}|hunger is {food}|tiredness is {sleep}|");

                        count++;
                        var choice = Console.ReadLine();
                        switch (choice)
                        {
                            // rest
                            case "1":
                                Console.Beep(200, 100);
                                Console.Beep(200, 100);
                                Console.Beep(250, 100);
                                Console.Beep(270, 200);
                                food = food - 2;
                                sleep = sleep + 1;
                                Console.WriteLine(".");                              
                                if (food <= 2)
                                {
                                    Console.WriteLine(" I'm Hungry! ");
                                }

                                break;
                            // feed
                            case "2":
                                Console.Beep(500, 100);
                                Console.Beep(500, 100);
                                Console.Beep(550, 100);
                                Console.Beep(570, 200);
                                sleep = sleep - 2;
                                food = food + 1;
                                Console.WriteLine(".");
                                if (sleep <= 2)
                                {
                                    Console.WriteLine(" I'm Tired! ");
                                }
                                break;
                            // Stats
                            case "3":
                                Console.Beep(500, 100);
                                Console.WriteLine(" ");
                                Console.WriteLine($" health is {hp}, hunger is {food} and tiredness is {sleep} ");
                                break;
                            // Clear console
                            case "4":
                                Console.Beep(1000, 80);
                                Console.Clear();
                                break;
                            // Error / invalid input
                            default:
                                Console.WriteLine("Something went wrong");
                                break;
                        }
                    }
                }
                //Console.Clear();    
            }
            // suppose to be save file

            //string hpString = hp.ToString();
            //string foodString = food.ToString();
            //string sleepString = sleep.ToString();
            //string save2 = string.Join("\u001F", hp, food, sleep);
            //File.WriteAllText(test.txt, text_to_be_saved)
            //timer1.Change(Timeout.Infinite, Timeout.Infinite);
            GameOver(name, count);
        }



        public static void GameOver(string name, int count)
        {

            Thread.Sleep(40);
            Thread.Sleep(40);
            Thread.Sleep(40);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            // Flat line gimmick
            Thread.Sleep(140); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Beep(1300, 150); Console.Write("/\\"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Beep(1300, 150); Console.Write("/\\"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Thread.Sleep(40); Console.Write("_"); Console.Beep(1300, 150); Console.Write("/\\"); Console.Beep(1300, 150); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Beep(1300, 2000); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Console.Write("_"); Thread.Sleep(40); Thread.Sleep(40); Console.WriteLine("_"); Console.Beep(1300, 2000);
            Console.WriteLine(" ");
            string deathDate = DateTime.Now.Year.ToString();
            string hedgDead = $@"
    .|||||||||.          
   |||||||||||||        
  |||||||||||x x\       {name} is dead and it lived for {count} days!
  `||||||||||_U__o    

        RIP 
      {name} 
    {deathDate}-{deathDate}                                                         ";
            Console.WriteLine(hedgDead);
            // new game call
            Console.WriteLine(" ");
            Console.WriteLine("Would you like to play again? 1 for yes, 2 for no");
            var choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("GAME OVER");
            }
        }
    }
}

