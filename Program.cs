using static System.Console;

public class Program{

    static void Main(){
        PickUp pickUp = new PickUp();
        HealthPickup healthPickup = new HealthPickup();

        WriteLine(pickUp.IsPickedUp);
        WriteLine(healthPickup.IsPickedUp);
        WriteLine(healthPickup.HPBoost);
    }

}