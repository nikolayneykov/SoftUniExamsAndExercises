function printPerfectNumbers(numbers) {
    let isPerfect = function (num) {
        let sum = 0;
        for (let i = 1; i < num; i++) {
            if (num % i === 0) {
                sum += i;
            }
        }

        return num === sum;
    }

    let perfectNumbers = [];

    for (let num of numbers) {
        if (isPerfect(num)) {
            perfectNumbers.push(num);
        }
    }

    console.log(perfectNumbers.length === 0 ? 'No perfect number' : perfectNumbers.join(', '));
}

printPerfectNumbers([5, 6, 28]);