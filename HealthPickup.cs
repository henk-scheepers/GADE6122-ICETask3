using static System.Console;

public class HealthPickup : PickUp{

    private int hpBoost = 10;

    public int HPBoost{
        get { return hpBoost; }
    }

    public override void DisplayTakeMessage(){
        WriteLine("Health pick-up taken.");
    }

    public override bool ApplyEffect(Player player)
    {
        player.Health += hpBoost;
        return false;
    }
}