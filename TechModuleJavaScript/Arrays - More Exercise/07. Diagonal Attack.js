function solve(params) {
    let matrix = [];
    for (let line of params) {
        matrix.push(line.split(/\s/).map(n => Number(n)));
    };
    let leftDiagonalSum = 0;
    let rightDiagonalSum = 0;
    for (let row = 0, colLeft = 0, colRight = matrix[0].length - 1;
        row < matrix.length; row++ , colLeft++ , colRight--) {
        leftDiagonalSum += matrix[row][colLeft];
        rightDiagonalSum += matrix[row][colRight];
    }
    if (leftDiagonalSum == rightDiagonalSum) {
        for (let row = 0; row < matrix.length; row++) {
            for (let col = 0; col < matrix[row].length; col++) {
                if (row - col != 0 && row + col != matrix.length - 1) {
                    matrix[row][col] = leftDiagonalSum;
                }
            }
        }
    }
    console.log(matrix.map(x => x.join(' ')).join('\n'));
}
solve(['5 3 12 3 1',
    '11 4 23 2 5',
    '101 12 3 21 10',
    '1 4 5 2 2',
    '5 22 33 11 1']);