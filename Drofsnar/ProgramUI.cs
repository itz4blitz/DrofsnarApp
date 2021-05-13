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
        private VulnerableBirdHunters _birdHunters = new VulnerableBirdHunters();
        public bool hasGainedExtraLife { get; set; } = false;

        public void Run()
        {
            ProgramUI ui = new ProgramUI();
            string[] gameText = ui.CreateGameSequence();
            RunGameSequence(gameText);
            Console.ReadLine();
        }

        public string[] CreateGameSequence()
        {
            string text = File.ReadAllText(@"C:\Users\jscroggins\source\repos\DrofsnarApp\Drofsnar\Game.txt");
            string[] gameText = text.Split(',');
            return gameText;
        }

        public void RunGameSequence(string[] gameEvents)
        {
            InitializeGame();
            var counter = 0;
            while (_game.IsAlive)
            {
                foreach (string gameEvent in gameEvents)
                {
                    counter++;
                    Console.Clear();
                    if (_game.TotalPoints >= 10000 && hasGainedExtraLife == false)
                    {
                        Console.WriteLine($"Drofsnar has earned 10,000 points; +1 life earned!");
                        _game.ExtraLifeEarned(_game);
                        hasGainedExtraLife = true;
                        Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
                        Thread.Sleep(1500);
                    }

                    if (gameEvent.ToLower().Contains("stopper"))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine("Drofsnar found a Stopper!");
                        _game.MakePlayerInvincible();
                        Thread.Sleep(1500);
                    }

                    if (gameEvent.ToLower() == "bird")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        if (counter > 0)
                        {
                            Console.Clear();
                        }
                        _game.TotalPoints += _bird.Value;
                        Console.WriteLine($"Caught a {_bird.Name}!");
                        Console.Write($"Earned {_bird.Value} points!\n");
                        Console.WriteLine($"Total Points: {_game.TotalPoints}");
                        Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
                        Console.Write($"{counter} of {gameEvents.Length}");
                        Thread.Sleep(500);
                    }

                    else if (gameEvent.ToLower() == "crestedibis")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        _game.TotalPoints += _crustedIbis.Value;
                        Console.WriteLine($"Caught a {_crustedIbis.Name}!");
                        Console.Write($"Earned {_crustedIbis.Value} points!\n");
                        Console.WriteLine($"Total Points: {_game.TotalPoints}");
                        Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
                        Console.Write($"{counter} of {gameEvents.Length}");
                        Thread.Sleep(500);
                    }

                    else if (gameEvent.ToLower() == "greatkiskudee")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        _game.TotalPoints += _greatKuskudee.Value;
                        Console.WriteLine($"Caught a {_greatKuskudee.Name}");
                        Console.Write($"Earned {_greatKuskudee.Value} points!\n");
                        Console.WriteLine($"Total Points: {_game.TotalPoints}");
                        Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
                        Console.Write($"{counter} of {gameEvents.Length}");
                        Thread.Sleep(500);
                    }

                    else if (gameEvent.ToLower() == "redcrossbill")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        _game.TotalPoints += _redCrossbill.Value;
                        Console.WriteLine($"Caught a {_redCrossbill.Name}!");
                        Console.Write($"Earned {_redCrossbill.Value} points!\n");
                        Console.WriteLine($"Total Points: {_game.TotalPoints}");
                        Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
                        Console.Write($"{counter} of {gameEvents.Length}");
                        Thread.Sleep(500);
                    }

                    else if (gameEvent.ToLower() == "red-neckedphalarope")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        _game.TotalPoints += _redneckedPhalarope.Value;
                        Console.WriteLine($"Caught a {_redneckedPhalarope.Name}!");
                        Console.Write($"Earned {_bird.Value} points!\n");
                        Console.WriteLine($"Total Points: {_game.TotalPoints}");
                        Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
                        Console.Write($"{counter} of {gameEvents.Length}");
                        Thread.Sleep(500);
                    }

                    else if (gameEvent.ToLower() == "eveninggrosbeak")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        _game.TotalPoints += _eveningGrosbeak.Value;
                        Console.WriteLine($"Caught a {_eveningGrosbeak.Name}!");
                        Console.Write($"Earned {_eveningGrosbeak.Value} points!\n");
                        Console.WriteLine($"Total Points: {_game.TotalPoints}");
                        Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
                        Console.Write($"{counter} of {gameEvents.Length}");
                        Thread.Sleep(500);
                    }

                    else if (gameEvent.ToLower() == "greaterprairiechicken")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        _game.TotalPoints += _greaterPrairieChicken.Value;
                        Console.WriteLine($"Caught a {_greaterPrairieChicken.Name}!");
                        Console.Write($"Earned {_greaterPrairieChicken.Value} points!\n");
                        Console.WriteLine($"Total Points: {_game.TotalPoints}");
                        Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
                        Console.Write($"{counter} of {gameEvents.Length}");
                        Thread.Sleep(500);
                    }

                    else if (gameEvent.ToLower() == "icelandgull")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        _game.TotalPoints += _icelandGull.Value;
                        Console.WriteLine($"Caught a {_icelandGull.Name}!");
                        Console.Write($"Earned {_icelandGull.Value} points!\n");
                        Console.WriteLine($"Total Points: {_game.TotalPoints}");
                        Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
                        Console.Write($"{counter} of {gameEvents.Length}");
                        Thread.Sleep(500);
                    }

                    else if (gameEvent.ToLower() == "orange-belliedparrot")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        _game.TotalPoints += _orangeBelliedParrot.Value;
                        Console.WriteLine($"Caught a {_orangeBelliedParrot.Name}!");
                        Console.Write($"Earned {_orangeBelliedParrot.Value} points!\n");
                        Console.WriteLine($"Total Points: {_game.TotalPoints}");
                        Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
                        Console.Write($"{counter} of {gameEvents.Length}");
                        Thread.Sleep(500);
                    }

                    else if (gameEvent.ToLower().Contains("birdhunter"))
                    {
                        if (gameEvent.ToLower().Contains("stopper"))
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.WriteLine($"Vulnerable to Bird Hunter: {_birdHunters.IsVulnerable}");
                            var result = _birdHunters.RunBirdHunterMultiplier();
                            Console.Write($"Captured Birdhunter! Earned {result} points!\n");
                            Console.WriteLine($"Total Points: {_game.TotalPoints}");
                            Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
                            _game.TotalPoints += result;
                            Console.Write($"{counter} of {gameEvents.Length}");
                            Thread.Sleep(500);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine($"Vulnerable to Bird Hunter: {_birdHunters.IsVulnerable}");
                            Console.WriteLine("Birdhunter chomps Drofsnar!");
                            Console.WriteLine($"Total Points: {_game.TotalPoints}");
                            Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
                            Console.Write($"{counter} of {gameEvents.Length}");
                            _game.TotalLives--;
                            var result = _game.IsPlayerAlive();
                            if (result == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Drofsnar is dead!");
                                Thread.Sleep(1500);
                                _game.IsAlive = false;
                                break;
                            }
                            Thread.Sleep(500);
                        }
                    }
                }
            }
            Console.Clear();
            ReturnGameResults();
            Console.WriteLine("Game finished!");
            Console.ReadLine();
        }
        public void ReturnGameResults()
        {
            Console.WriteLine($"Total Points: {_game.TotalPoints}");
            Console.WriteLine($"Remaining Lives: {_game.TotalLives}");
        }

        public void InitializeGame()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Starting Points: {_game.TotalPoints} ");
            Thread.Sleep(1000);
            Console.WriteLine($"Starting Lives: {_game.TotalLives} ");
            Thread.Sleep(1000);
            Console.WriteLine("Drofsnar begins his journey around the world...");
            Thread.Sleep(2000);
        }
    }
}
