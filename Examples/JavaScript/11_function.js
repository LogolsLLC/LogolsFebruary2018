let yearTraveledHistory = [];
let count = 0;
if (TimeTravel(2005))
{
    yearTraveledHistory[count] = 2005;
    count++;
}
if (TimeTravel(1985))
{
    yearTraveledHistory[count] = 1985;
    count++;
}
if (TimeTravel(1971))
{
    yearTraveledHistory[count] = 1971;
    count++;
}
if (TimeTravel(1964))
{
    yearTraveledHistory[count] = 1964;
    count++;
}
if (TimeTravel(2016))
{
    yearTraveledHistory[count] = 2016;
    count++;
}
if (TimeTravel(1980))
{
    yearTraveledHistory[count] = 1980;
    count++;
}
WriteYearsTraveled(yearTraveledHistory);

function TimeTravel(year){
    console.log("You are traveling to " + year);
    if(year != 1985)
    {
        console.log("You have arrived");
        return true;
    }
    else
    {
        console.log("Travel failed");
        return false;
    }
}

function WriteYearsTraveled(yearTraveledHistory){
    console.log("Here is a list of the years you have traveled to: ");
    for(let year of yearTraveledHistory)
    {
        console.log(year);
    } 
}