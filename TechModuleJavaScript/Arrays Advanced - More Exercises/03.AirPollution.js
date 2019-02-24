function solve(params, commands) {
    let matrix = [];
    for (let i = 0; i < params.length; i++) {
        matrix[i] = params[i].split(' ').map(Number);
    }

    for (let line of commands) {
        let tokens = line.split(' ');
        let command = tokens[0];
        let number = Number(tokens[1]);
        switch (command) {
            case 'breeze':
                for (let i = 0; i < 5; i++) {
                    matrix[number][i] -= 15;
                }
                break;
            case 'gale':
                for (let i = 0; i < 5; i++) {
                    matrix[i][number] -= 20;
                }
                break;
            case 'smog':
                matrix = matrix.map(row => row.map(num => num + number));
                break;
        }
        matrix = matrix.map(row => row.map(num => num < 0 ? num = 0 : num));
    }
    findPolutedAreas(matrix);
    function findPolutedAreas(matrix) {
        let polutedAreas = [];
        for (let row = 0; row < matrix.length; row++) {
            for (let col = 0; col < matrix[row].length; col++) {
                if (matrix[row][col] >= 50) {
                    polutedAreas.push(`[${row}-${col}]`);
                }
            }
        }
        if (polutedAreas.length > 0) {
            console.log('Polluted areas: ' + polutedAreas.join(', '));
        } else {
            console.log('No polluted areas')
        }
    }
}