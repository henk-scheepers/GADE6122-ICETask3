// Project -> Add Class (PickUp.cs)
using System;
using static System.Console;

public abstract class PickUp{
    private int x;
    private int y;
    private bool isPickedUp;

    public bool IsPickedUp{
        get { return isPickedUp; }
    }

    public PickUp(){
        Random rand = new Random();
        x = rand.Next(0,10);
        y = rand.Next(0,10);

        isPickedUp = false;
    }

    public bool Take(int x, int y){
        if(!isPickedUp && this.x == x && this.y == y){
            isPickedUp = true;
            return true;
        }

        return false;
    }

    public virtual void DisplayTakeMessage(){
        WriteLine("Pick-up picked up");
    }

    public abstract bool ApplyEffect(Player player);
}