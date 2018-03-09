/*
multiline
comment
*/

//here are some variables I might need

let timeTravelComplete = false; //indicator of whether I have completed travel
const travelYear = 2017; //year to travel to
let minutesTraveled = 5.35; //number of minutes traveled
let travelCompleteMessage = 'You have arrived.'; //message to display when travel is completed
let yearTraveledHistory = [1975, 1960, 1985, 2012]; //years traveled to.
console.log("timeTravelComplete: " + timeTravelComplete);
console.log("travelYear: " + travelYear);
console.log("minutesTraveled: " + minutesTraveled);
console.log("travelCompleteMessage: " + travelCompleteMessage);
count = 1;
for(let val of yearTraveledHistory){
    console.log("yearTraveledHistory index " + count + ": " + val);
    count++;
}