using System;
using static System.Console;

public class ExitPickup : PickUp{

    public override bool ApplyEffect(Player player)
    {
        return true;
    }

    public override void DisplayTakeMessage()
    {
        WriteLine("Congratulations, you finished the game! Yay!");
    }
}