using System;
using static System.Console;

public class PortkeyPickup : PickUp{

    static Random random = new Random();

    public override bool ApplyEffect(Player player)
    {
        player.SetPosition(random.Next(0, 10), random.Next(0,10));

        return false;
    }

    public override void DisplayTakeMessage()
    {
        WriteLine("Player teleported to a new unknown location");
    }
}