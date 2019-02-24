function printSequence(n, k) {
    let result = [1];
    while (result.length < n) {
        let lastKNumbers = result.slice(-k);
        let sum = 0;
        for (let num of lastKNumbers) {
            sum += num;
        }
        result.push(sum);
    }
    console.log(result.join(' '));
}
printSequence(6, 3);