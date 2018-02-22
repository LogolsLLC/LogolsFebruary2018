let statuses = [3,4,2,1,4,2,3];
let names = ['Tim','Tom','Bob','Joe','Jake','John','Steve'];
console.log('for loop');
for(count = 0; count < statuses.length; count++){
    let status = statuses[count];
    let name = names[count];
    console.log(name + ':');
    switch(status){
        case 1:
            console.log('Alive');
            break;
        case 2:
            console.log('Zombie');
            break;
        case 3:
            console.log('Dead');
            break;
        case 4:
            console.log('Unknown');
            break;
    }
}

count = 0;
console.log('while loop');
while(count < statuses.length){
    let status = statuses[count];
    let name = names[count];
    console.log(name + ':');
    switch(status){
        case 1:
            console.log('Alive');
            break;
        case 2:
            console.log('Zombie');
            break;
        case 3:
            console.log('Dead');
            break;
        case 4:
            console.log('Unknown');
            break;
    }
    count++;
}

count = 0;
console.log('do while loop');
do{
    let status = statuses[count];
    let name = names[count];
    console.log(name + ':');
    switch(status){
        case 1:
            console.log('Alive');
            break;
        case 2:
            console.log('Zombie');
            break;
        case 3:
            console.log('Dead');
            break;
        case 4:
            console.log('Unknown');
            break;
    }
    count++;
} while(count < statuses.length)

let personStatuses = [
    {status:4,name:'Tim'},
    {status:2,name:'Tom'},
    {status:1,name:'Bob'},
    {status:3,name:'John'},
    {status:2,name:'Joe'},
    {status:1,name:'Steve'}
];
console.log('for of loop');
for(let personStatus of personStatuses){
    console.log(personStatus.name + ':');
    switch(personStatus.status){
        case 1:
            console.log('Alive');
            break;
        case 2:
            console.log('Zombie');
            break;
        case 3:
            console.log('Dead');
            break;
        case 4:
            console.log('Unknown');
            break;
    }
}