function divison(num) {
    let divisionNum = -1;
    if (num % 10 === 0) {
        divisionNum = 10;
    } else if (num % 7 === 0) {
        divisionNum = 7;
    } else if (num % 6 === 0) {
        divisionNum = 6;
    } else if (num % 3 === 0) {
        divisionNum = 3;
    } else if (num % 2 === 0) {
        divisionNum = 2;
    }

    if (divisionNum===-1) {
        console.log('Not divisible');
    }else{
        console.log(`The number is divisible by ${divisionNum}`);
    }
}

divison(1643);
