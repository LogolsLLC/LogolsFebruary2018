let correctAnswer = 2;
let correctAnswer2 = 3;
if(correctAnswer == getAnswer() && correctAnswer2 == getAnswer2() && getAnswer3() > 5){
    console.log("You are correct!");
}
else{
    console.log("Sorry, that is not correct.");
}

function getAnswer(){
    console.log("Verify your identity:  What state do you live in?");
    console.log("[1] Ohio");
    console.log("[2] Michigan");
    console.log("[3] Indiana");
    console.log("[4] Florida");
    return require('readline-sync').question('');
}

function getAnswer2(){
    console.log("What is your cats name?");
    console.log("[1] Frank");
    console.log("[2] Tommy");
    console.log("[3] Jonah");
    console.log("[4] Whiskers");
    return require('readline-sync').question('');
}

function getAnswer3(){
    console.log("Enter a number greater than 5");
    return require('readline-sync').question('');
}