function solve(params) {
    let matrix = [];
    for (let i = 0; i < params.length - 1; i++) {
        let currentLine = params[i].split(' ').filter(x => x !== '').map(Number);
        matrix.push(currentLine);
    }
    let totalDamage = 0;
    let killedBunnies = 0;
    let bombIndexes = params[params.length - 1].split(' ').filter(x => x !== '');

    for (let i of bombIndexes) {
        let tokens = i.split(',').filter(x => x !== '').map(Number);
        let bombRow = tokens[0];
        let bombCol = tokens[1];

        if (matrix[bombRow][bombCol] !== 0) {
            let bombDamage = matrix[bombRow][bombCol];
            matrix[bombRow][bombCol] = 0;
            for (let row = Math.max(0, bombRow - 1); row <= Math.min(matrix.length - 1, bombRow + 1); row++) {
                for (let col = Math.max(0, bombCol - 1); col <= Math.min(matrix[0].length - 1, bombCol + 1); col++) {
                    matrix[row][col] = Math.max(0, matrix[row][col] - bombDamage);
                }
            }
            totalDamage += bombDamage;
            killedBunnies++;
        }
    }
    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[0].length; col++) {
            if (matrix[row][col] > 0) {
                totalDamage += matrix[row][col];
                killedBunnies++;
                matrix[row][col] = 0;
            }
        }
    }

    return `${totalDamage}\n${killedBunnies}`;
}
console.log(solve(['5 10 15 20',
    '10 10 10 10',
    '10 15 10 10',
    '10 10 10 10',
    '2,2 0,1']
));