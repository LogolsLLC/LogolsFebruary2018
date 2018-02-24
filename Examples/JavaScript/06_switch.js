console.log("Please enter your name:");
let enteredName = require('readline-sync').question('');
switch(enteredName)
{
    case "Joe":
        console.log("You have full access.");
        break;
    case "Stan":
        console.log("You have access to command, but not travel.");
        break;
    case "Laura":
        console.log("You have access to travel, but not command.");
        break;
    default:
        console.log("You do not have access.");
        break;
}