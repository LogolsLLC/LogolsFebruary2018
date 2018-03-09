let status = 2;
if(status === 1){
    console.log('Alive');
}
else if(status === 2){
    console.log('Zombie');
}
else if(status === 3){
    console.log('Dead');
}
else if(status === 4){
    console.log('Unknown');
}

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