using System;

string[] coins = { "Tails", "Heads" };
var flipChance = new Random();
string flipResult = coins[flipChance.Next(coins.Length)];
Console.WriteLine(flipResult);
Console.ReadKey(); // I will probably add an option to flip again but idk
