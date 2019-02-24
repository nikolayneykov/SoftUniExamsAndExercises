function searchNumber(arr, numbers) {
    let numbersToTake = numbers[0];
    let index = numbers[1];
    let numberToSearch = numbers[2];

    let count = arr
        .slice(0, numbersToTake)
        .slice(index)
        .filter(num => num === numberToSearch)
        .length;
    console.log(`Number ${numberToSearch} occurs ${count} time.`);

}

searchNumber([5, 2, 3, 4, 1, 6],
    [5, 2, 3]
);