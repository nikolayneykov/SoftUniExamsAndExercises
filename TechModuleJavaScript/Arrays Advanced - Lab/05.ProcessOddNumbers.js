function processOddNum(arr) {
    let result = arr.filter((num, index) => index % 2 === 1).map(num => num *= 2).reverse();
    console.log(result.join(' '));
}
processOddNum([10, 15, 20, 25]);