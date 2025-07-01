/*creando clase  */
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
    if (message.Contains("quick"))
    {
        Console.WriteLine("The fox is quick!");
    }
    else
    {
        Console.WriteLine("The fox is not quick.");

    }
}
// Simulating a dice roll game
Random dice = new Random();

int roll1 = dice.Next(1, 7);

int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (total >= 10)
{
    Console.WriteLine("You win!");
    if(total == 15)
    {
        Console.WriteLine("Jackpot!");
    }
}
else
{
    Console.WriteLine("You lose!");
}


