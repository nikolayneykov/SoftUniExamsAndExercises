function solve(params) {
    let matrix = [];
    let startRow = params[2];
    let startCol = params[3];
    for (let row = 0; row < params[0]; row++) {
        matrix[row] = [];
        for (let col = 0; col < params[1]; col++) {
            matrix[row][col] = 0;
        }
    }
    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            matrix[row][col] = Math.max(Math.abs(row - startRow), Math.abs(col - startCol)) + 1;
        }
    }
    console.log(matrix.map(x => x.join(' ')).join('\n'));
}
solve([4, 4, 0, 0]);