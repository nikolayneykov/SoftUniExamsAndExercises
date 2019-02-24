function printFirstKAndLastKNumbers(arr) {
    let k = arr.shift();
    let firstNumbers = arr.slice(0,k);
    let lastNumbers = arr.slice(arr.length-k);
    console.log(`${firstNumbers.join(' ')}\n${lastNumbers.join(' ')}`);
}
printFirstKAndLastKNumbers([2, 7, 8, 9]);