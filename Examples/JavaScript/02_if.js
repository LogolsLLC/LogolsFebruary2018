let correctAnswer = 2;
if(correctAnswer == getAnswer()) {
    console.log("You are correct!");
}
else {
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