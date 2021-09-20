// Project -> Add Class (PickUp.cs)
using System;

public class PickUp{
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
}