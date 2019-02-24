function printSpecialNumbers(n) {
    for (let i = 1; i <= n; i++) {
        let sum = 0;
        let numAsString = i.toString();
        for (let j = 0; j < numAsString.length; j++) {
            sum += Number(numAsString[j]);
        }
        if (sum === 5 || sum === 7 || sum === 11) {
            console.log(`${numAsString} -> True`);
        }else{
            console.log(`${numAsString} -> False`);
        }
    }
}

printSpecialNumbers(92);