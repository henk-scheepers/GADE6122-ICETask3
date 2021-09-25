using static System.Console;

public class Player{
    int x;
    int y;

    public int X{
        get{ return x; }
    }

    public int Y{
        get{ return y; }
    }

    public int Health{get; set;}

    public Player(){
        //x = 0;
        //y = 0;
        x = y = 0;
        Health = 100;
    }
 
    public void Move(){
        string input = ReadLine().ToLower();

        switch(input){
            case "up": y += 1; break;
            case "down": y -= 1; break;
            case "left": x -= 1; break;
            case "right": x += 1; break;
        }

        if(x < 0){
            x = 0;
        }

        if(x > 9){
            x = 9;
        }

        if(y < 0){
            y = 0;
        }

        if(y > 9){
            y = 9;
        }
    }

    public override string ToString(){
        return GetType() + ": " + x + ", " + y + "(" + Health + ")";
        //return $"{GetType()}: {x}, {y} ({Health})";
    }

    public void SetPosition(int x, int y){
        if(x >= 0 && x <= 9){
            this.x = x;
        }

        if(y >= 0 && y <= 9){
            this.y = y;
        }
    }
}