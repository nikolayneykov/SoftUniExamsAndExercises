function numberModification(input) {
    let digits = input.toString().split('').map(Number);
    let averageSum = digits.reduce((a, b) => a + b, 0) / digits.length;

    while (averageSum < 5) {
        digits.push(9);
        averageSum = digits.reduce((a, b) => a + b, 0) / digits.length;
    }

    console.log(digits.join(''));
}
