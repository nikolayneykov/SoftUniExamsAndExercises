function printSumOfDigits(num) {
    let sum = 0;
    let numAsString = num.toString();
    for (let i = 0; i < numAsString.length; i++) {
        sum += Number(numAsString[i]);
    }
    console.log(sum);
}
printSumOfDigits(245678);