using static System.Console;

public class TrapPickup : PickUp{

    private int damage;

    public int Damage{
        get { return damage; }
    }

    public TrapPickup(){
        damage = 20;
    }

    public override bool ApplyEffect(Player player)
    {
        player.Health -= damage;

        return player.Health <= 0;
        // if(player.Health <= 0){
        //     return true;
        // }else{
        //     return false;
        // }
    }

    public override void DisplayTakeMessage()
    {
        WriteLine("Player stepped in a trap and lost 20hp");
    }
}