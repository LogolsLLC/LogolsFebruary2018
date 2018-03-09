abstract class TimeMachine
{
    public TravelHistory:number[];
    
    public constructor(){
        this.TravelHistory = [];
        console.log("The time machine has been created.");
    }

    public timeTravel(year:number):void{
        console.log("You are traveling to " + year);
        console.log("You have arrived");
        this.TravelHistory.push(year);
    }
}

class DirectRouteTimeMachine extends TimeMachine
{

}

class MultipleHopTimeMachine extends TimeMachine
{
    public timeTravel(year:number):void
    {
        super.timeTravel(year + 5);
        super.timeTravel(year);
    }       
}

let direct:TimeMachine = new DirectRouteTimeMachine();
let hop:TimeMachine = new MultipleHopTimeMachine();
direct.timeTravel(1990);
hop.timeTravel(1990);