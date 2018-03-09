let correctAnswer = 2;
if(correctAnswer == getAnswer()){
    console.log("You are correct!");
}
else{
    console.log("Sorry, that is not correct, try again?");
    let response = require('readline-sync').question('');
    if(response == "Y"){
        if(getAnswer() == correctAnswer){
            console.log("You got it on the second try!");
        }
        else{
            console.log("Sorry, still not correct");
        }
    }
}

function getAnswer(){
    console.log("Verify your identity:  What state do you live in?");
    console.log("[1] Ohio");
    console.log("[2] Michigan");
    console.log("[3] Indiana");
    console.log("[4] Florida");
    return require('readline-sync').question('');
}