function printNumberType(firstNum, secondNum, thirdNum) {
    let sum = firstNum + secondNum + thirdNum;
    if (sum % 1 === 0) {
        console.log(`${sum} - Integer`)
    } else {
        console.log(`${sum} - Float`)
    }
}
printNumberType(100.5, 200, 303);