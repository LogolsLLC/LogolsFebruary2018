let personStatuses = [
    {status:4,name:'Tim'},
    {status:2,name:'Tom'},
    {status:1,name:'Bob'},
    {status:3,name:'John'},
    {status:2,name:'Joe'},
    {status:1,name:'Steve'}
];
for(let personStatus of personStatuses){
    writeString(getPersonStatusDescription(personStatus));
}

function getPersonStatusDescription(personStatus){
    let statusString = 'Status for ' + personStatus.name + ' is ';
    switch(personStatus.status){
        case 1:
            statusString += 'Alive';
            break;
        case 2:
            statusString += 'Zombie';
            break;
        case 3:
            statusString += 'Dead';
            break;
        case 4:
            statusString += 'Unknown';
            break;
    }
    return statusString;
}

function writeString(value){
    console.log(value);
}