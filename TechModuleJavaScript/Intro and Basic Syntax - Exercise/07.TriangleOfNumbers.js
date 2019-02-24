function printTriangleOfNumbers(n) {

    for (let row = 1; row <= n; row++) {
        let line = '';
        for (let col = 1; col <= row; col++) {
            line += row + ' ';
        }
        console.log(line);
    }
}

printTriangleOfNumbers(9);