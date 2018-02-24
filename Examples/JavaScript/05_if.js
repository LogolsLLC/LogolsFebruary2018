console.log("Please enter your name:");
let enteredName = require('readline-sync').question('');
if(enteredName == "Joe"){
    console.log("You have full access.");
}
else if(enteredName == "Stan"){
    console.log("You have access to command, but not travel.");
}
else if(enteredName == "Laura"){
    console.log("You have access to travel, but not command.");
}
else{
    console.log("You do not have access.");
}