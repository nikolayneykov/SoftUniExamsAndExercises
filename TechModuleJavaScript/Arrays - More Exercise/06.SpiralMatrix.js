function printSpiralMatrix(rows, cols) {
    let matrix = [];
    for (let r = 0; r < rows; r++) {
        matrix.push([]);
    }
    let count = 1;
    let limitCount = rows * cols;
    let limitLeft = 0;
    let limitRight = rows;
    let limitUp = 0;
    let limitDown = cols;
    let currentRow = 0;
    let currentCol = 0;
    while (count < limitCount) {
        while (currentCol < limitRight - 1) {
            matrix[currentRow][currentCol] = count;
            currentCol++;
            count++;
        }
        limitUp++;
        while (currentRow < limitDown - 1) {
            matrix[currentRow][currentCol] = count;
            currentRow++;
            count++;
        }
        limitRight--;
        while (currentCol > limitLeft) {
            matrix[currentRow][currentCol] = count;
            currentCol--;
            count++;
        }
        limitDown--;
        while (currentRow > limitUp) {
            matrix[currentRow][currentCol] = count;
            currentRow--;
            count++;
        }
        limitLeft++;
    }
    matrix[currentRow][currentCol] = count;

    for (let row = 0; row < matrix.length; row++) {
        console.log(matrix[row].join(' '));
    }
}
console.log(printSpiralMatrix(5, 5));