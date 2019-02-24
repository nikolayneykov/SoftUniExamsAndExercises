function printBiggestMultiplication(numbers) {
    let biggestMultiplication = Number.NEGATIVE_INFINITY;

    for (let i = 0; i < numbers.length; i++) {
        if (numbers[i].length === 1) {
            let currentMultiplication = 1;
            let currentNum = Number(numbers[i]);
            for (let j = i + 1; j <= i + currentNum; j++) {
                currentMultiplication *= Number(numbers[j]);
            }
            if (biggestMultiplication < currentMultiplication) {
                biggestMultiplication = currentMultiplication;
            }
        }
    }
    console.log(biggestMultiplication);
}
printBiggestMultiplication(['10',
    '20',
    '2',
    '30',
    '44',
    '3',
    '56',
    '20',
    '24']
);