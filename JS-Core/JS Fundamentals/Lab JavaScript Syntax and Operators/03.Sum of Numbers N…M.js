function printSumOfNumberRange(n, m) {
    let start = Number(n);
    let end = Number(m);

    let sum = 0;
    for (let i = start; i <= end; i++) {
        sum += i;
    }

    console.log(sum);
}
printSumOfNumberRange('1', '5');