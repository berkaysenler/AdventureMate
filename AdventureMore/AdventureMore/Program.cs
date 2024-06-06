// Berkay Senler

Console.WriteLine("Welcome the the Adventure Game!");
Console.WriteLine("Please enter your character's name: ");
string charName = Console.ReadLine();

while (true)
{
    Console.WriteLine("Please choose your character type (Warrior, Wizard, Archer)");
    string charType = Console.ReadLine().ToUpper();
    if (charType != "WARRIOR" && charType != "WIZARD" && charType != "ARCHER")
    {
        Console.WriteLine("Invalid entry.");
        
    }
    else
    {
        Console.WriteLine("You, {0} the {1} find yourself at the edge of a dark forest! ", charName, charType);
        Console.WriteLine("Do you enter the forest or camp outside? (Forest/Camp)");
        break;
    }
}

string choice1 = Console.ReadLine();

switch (choice1.ToLower())
{
	case "forest":
        Console.WriteLine("You bravely enter the forest");
        break;
    case "camp":
        Console.WriteLine("You decide to camp out and wait for daylight");
        break;

    default:
        Console.WriteLine("Invalid choice. You decide to camp out by default.");
        break;
}
bool gameContinues = true;

while (gameContinues)
{
    Console.WriteLine("You come to a fork in the road. Go left or right?");
    string direction = Console.ReadLine();

    switch (direction.ToLower())
    {
        case "left":
            Console.WriteLine("You find a treasure chest!");
            gameContinues = false;
            break;
        case "right":
            Console.WriteLine("You encounter a wild beast");
            Console.WriteLine("Fight or flee? (fight/flee)");
            string fightChoice = Console.ReadLine();
            switch (fightChoice.ToLower())
            {
                case "fight":
                    Random random = new Random();
                    int luck = random.Next(1,11);
                    if(luck > 5)
                    {
                        Console.WriteLine("You beat the wild beast!");
                        if (luck > 8)
                        {
                            Console.WriteLine("The wild beast dropped a treasure and you survived");
                            gameContinues = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The beast attacked you where you didn't expect it!");
                        Console.WriteLine("It rammed it's tusks into your chest and you bleed out!");
                        gameContinues = false;
                    }
                    break;
                case "flee":
                    Console.WriteLine("You saved your ass!");
                    gameContinues = false;
                    break;


                default:
                    Console.WriteLine("Invalid choice. The beast attacks you whili you hesitate! ");
                    Console.WriteLine("You bleed out from your wounds.");
                    gameContinues = false;
                    break;
            }
            break;
        default:
            Console.WriteLine("Invalid direction. You get lost in the forest and never find your way out. ");
            gameContinues=false;
            break;
    }
}
Console.WriteLine("Game Over!");
Console.WriteLine("Thank you for playing the game!");
Console.ReadKey();