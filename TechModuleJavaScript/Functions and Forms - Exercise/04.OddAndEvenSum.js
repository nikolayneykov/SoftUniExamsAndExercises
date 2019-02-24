function printOddAndEvenSum(number) {
    let oddSum = 0;
    let evenSum = 0;
    number = number.toString().split('').map(Number);
    for (let i = 0; i < number.length; i++) {
        if (number[i] % 2 === 0) {
            evenSum += number[i];
        } else {
            oddSum += number[i];
        }
    }
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}
printOddAndEvenSum(3495892137259234);