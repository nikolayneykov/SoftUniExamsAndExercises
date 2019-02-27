function printSum(num) {
    let digits = num.toString().split('').map(Number);
    let sum = 0;
    let areEqual = true;

    for (let i = 0; i < digits.length; i++) {
        let currentDigit = digits[i];
        sum += currentDigit;

        if (digits[i + 1] !== undefined &&
            areEqual === true &&
            currentDigit !== digits[i + 1]) {
            areEqual = false;
        }
    }

    console.log(`${areEqual}\n${sum}`);
}

printSum(22222282);