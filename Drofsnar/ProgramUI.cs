using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Drofsnar
{
    public class ProgramUI
    {
        private Game _game = new Game(5000, true, false, 3);
        private Bird _bird = new Bird();
        private CrustedIbis _crustedIbis = new CrustedIbis();
        private EveningGrosbeak _eveningGrosbeak = new EveningGrosbeak();
        private GreaterPrairieChicken _greaterPrairieChicken = new GreaterPrairieChicken();
        private GreatKuskudee _greatKuskudee = new GreatKuskudee();
        private IcelandGull _icelandGull = new IcelandGull();
        private OrangeBelliedParrot _orangeBelliedParrot = new OrangeBelliedParrot();
        private RedCrossbill _redCrossbill = new RedCrossbill();
        private RedneckedPhalarope _redneckedPhalarope = new RedneckedPhalarope();
        private VulnerableBirdHunters _vulnerableBirdHunters = new VulnerableBirdHunters();
        public bool isRunning;

        public void Run()
        {
            ProgramUI ui = new ProgramUI();
            string[] gameText = ui.CreateGameSequence();
            Console.WriteLine(RunGameSequence(gameText));
            Console.ReadLine();
        }

        public string[] CreateGameSequence()
        {
            string text = File.ReadAllText(@"C:\Users\jscroggins\source\repos\DrofsnarApp\Drofsnar\Game.txt");
            string[] gameText = text.Split(',');
            return gameText;
        }

        public string RunGameSequence(string[] gameEvents)
        {
            Console.WriteLine($"Starting Points: {_game.TotalPoints} ");
            Thread.Sleep(500);
            Console.WriteLine($"Starting Lives: {_game.TotalPoints} ");
            Thread.Sleep(500);
            Console.WriteLine("Drofsnar begins his journey around the world...");
            Thread.Sleep(500);

            foreach (string gameEvent in gameEvents)
            {
                if(_game.TotalPoints <= 10000)
                {

                    _game.ExtraLifeEarned(_game);
                }

                if (gameEvent.ToLower().Contains("stopper"))
                {
                    _game.MakePlayerInvincible();
                }

                if (gameEvent.ToLower() == "bird")
                {
                    _game.TotalPoints += _bird.Value;
                    Console.WriteLine($"Caught a {_bird.Name}!");
                    Console.Write($"Total Points: {_bird.Value} \n+{_game.TotalPoints} points\n");
                }

                else if (gameEvent.ToLower() == "crestedibis")
                {
                    _game.TotalPoints += _crustedIbis.Value;
                    Console.WriteLine($"Caught a {_crustedIbis.Name}!");
                    Console.Write($"Total Points: {_crustedIbis.Value} \n+{_game.TotalPoints} points\n");
                }

                else if (gameEvent.ToLower() == "greatkiskudee")
                {
                    _game.TotalPoints += _greatKuskudee.Value;
                    Console.WriteLine($"Caught a {_greatKuskudee.Name}");
                    Console.Write($"Total Points: {_greatKuskudee.Value} \n+{_game.TotalPoints} points\n");
                }

                else if (gameEvent.ToLower() == "redcrossbill")
                {
                    _game.TotalPoints += _redCrossbill.Value;
                    Console.WriteLine($"Caught a {_redCrossbill.Name}!");
                    Console.Write($"Total Points: {_redCrossbill.Value} \n+{_game.TotalPoints} points\n");
                }

                else if (gameEvent.ToLower() == "red-neckedphalarope")
                {
                    _game.TotalPoints += _redneckedPhalarope.Value;
                    Console.WriteLine($"Caught a {_redneckedPhalarope.Name}!");
                    Console.Write($"Total Points: {_redneckedPhalarope.Value} \n+{_game.TotalPoints} points\n");
                }

                else if (gameEvent.ToLower() == "eveninggrosbeak")
                {
                    _game.TotalPoints += _eveningGrosbeak.Value;
                    Console.WriteLine($"Caught a {_eveningGrosbeak.Name}!");
                    Console.Write($"Total Points: {_eveningGrosbeak.Value} \n+{_game.TotalPoints} points\n");
                }

                else if (gameEvent.ToLower() == "greaterprairiechicken")
                {
                    _game.TotalPoints += _greaterPrairieChicken.Value;
                    Console.WriteLine($"Caught a {_greaterPrairieChicken.Name}!");
                    Console.Write($"Total Points: {_greaterPrairieChicken.Value} \n+{_game.TotalPoints} points\n");
                }

                else if (gameEvent.ToLower() == "icelandgull")
                {
                    _game.TotalPoints += _icelandGull.Value;
                    Console.WriteLine($"Caught a {_icelandGull.Name}!");
                    Console.Write($"Total Points: {_icelandGull.Value} \n+{_game.TotalPoints} points\n");
                }

                else if (gameEvent.ToLower() == "orange-belliedparrot")
                {
                    _game.TotalPoints += _orangeBelliedParrot.Value;
                    Console.WriteLine($"Caught a {_orangeBelliedParrot.Name}!");
                    Console.Write($"Total Points: {_orangeBelliedParrot.Value} \n+{_game.TotalPoints} points\n");
                }

                else if (gameEvent.ToLower().Contains("birdhunters"))
                {
                    if (gameEvent.ToLower().Contains("stopper"))
                    {

                    }
                }
                ReturnGameResults();
            }
            return "Game Over!";
        }
        public void ReturnGameResults()
        {
            Console.WriteLine($"Total Points: {_game.TotalPoints}");
            Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
        }
    }

}
