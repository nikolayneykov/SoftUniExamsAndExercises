function calcCommonNumbers(arr1, arr2, arr3) {
    let commonNumbers = arr1
        .filter(x => arr2.includes(x) && arr3.includes(x))
        .sort((a, b) => a - b);

    let average = commonNumbers.reduce((a, b) => a + b, 0) / commonNumbers.length;

    let median = commonNumbers.length % 2 === 0 ?
        (commonNumbers[Math.floor(commonNumbers.length / 2) - 1] +
            commonNumbers[Math.floor(commonNumbers.length / 2)]) / 2 :
        commonNumbers[Math.floor(commonNumbers.length / 2)];

    console.log(`The common elements are ${commonNumbers.join(', ')}.\n` +
        `Average: ${average}.\n` +
        `Median: ${median}.`
    );
}

// calcCommonNumbers(
//     [5, 6, 50, 10, 1, 2],
//     [5, 4, 8, 50, 2, 10],
//     [5, 2, 50]
// );

calcCommonNumbers(
    [1, 2, 3, 4, 5],
    [3, 2, 1, 5, 8],
    [2, 5, 3, 1, 16]
)