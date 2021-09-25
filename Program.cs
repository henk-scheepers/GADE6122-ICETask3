using static System.Console;

public class Program{

    static Player player;

    static void Main(){
        player = new Player();

        PickUp[] pickUps = new PickUp[20];
        for(int i = 0; i < pickUps.Length; i++){
            if(i < 5){
                pickUps[i] = new PortkeyPickup();
            }
            else if(i < 10){
                pickUps[i] = new HealthPickup();
            }
            else if(i < 19){
                pickUps[i] = new TrapPickup();
            }
            else{
                pickUps[i] = new ExitPickup();
            }
        }

        while(true){
            player.Move();
            WriteLine(player);

            foreach(PickUp pickUp in pickUps){
                CheckPickup(pickUp);
            }
        }
    }

    static void CheckPickup(PickUp p){
        bool wasPickedUp = p.Take(player.X, player.Y);
        if(wasPickedUp){
            p.DisplayTakeMessage();
            p.ApplyEffect(player);
        }
    }

}