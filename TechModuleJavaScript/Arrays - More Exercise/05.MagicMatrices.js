function isMagicMatrix(matrix) {
    let sum = matrix[0].reduce((a, b) => a + b);
    let result = true;

    for (let i = 0; i < matrix.length; i++) {
        let horizontalSum = matrix[i].reduce((a, b) => a + b, 0);
        let verticalSum = matrix.map((row) => row[i]).reduce((a, b) => a + b, 0);
        if (sum !== horizontalSum || sum !== verticalSum) {
            result = false;
            break;
        }
    }
    console.log(result);
}

isMagicMatrix([[4, 5, 6],
[6, 5, 4],
[5, 5, 5]]
);