using System;
public class Player
{
    Random diceRoll = new Random();
    public int RollDie() => diceRoll.Next(1,18);
    public double GenerateSpellStrength() => diceRoll.NextDouble()*100;
}