interface ITimeMachine
{
    TravelHistory:number[];
    timeTravel(year:number):void;
}

class DirectRouteTimeMachine implements ITimeMachine
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

class MultipleHopTimeMachine implements ITimeMachine
{
    public TravelHistory:number[];   

    public constructor(){
        this.TravelHistory = [];
        console.log("The time machine has been created.");
    }

    public timeTravel(year:number):void{
        this.hop(year + 5);
        this.hop(year);
    }    
    
    public hop(year:number):void{
        console.log("You are traveling to " + year);
        console.log("You have arrived");
        this.TravelHistory.push(year);
    }
}

let direct:ITimeMachine = new DirectRouteTimeMachine();
let hop:ITimeMachine = new MultipleHopTimeMachine();
direct.timeTravel(1990);
hop.timeTravel(1990);