function solve(matrix) {
    let equalNeighbors = 0;
    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length - 1; col++) {
            if (matrix[row][col] === matrix[row][col + 1]) {
                equalNeighbors++;
            }
        }
    }
    for (let row = 0; row < matrix.length - 1; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            if (matrix[row][col] === matrix[row + 1][col]) {
                equalNeighbors++;
            }
        }
    }
    console.log(equalNeighbors);
}