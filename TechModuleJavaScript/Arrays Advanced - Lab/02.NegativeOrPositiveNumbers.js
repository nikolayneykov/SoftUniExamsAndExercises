function printNegativeAndPositiveNumbers(arr) {
    let result = [];
    arr.forEach(num => num < 0 ? result.unshift(num) : result.push(num));
    console.log(result.join('\n'));
}
printNegativeAndPositiveNumbers([7, -2, 8, 9]);