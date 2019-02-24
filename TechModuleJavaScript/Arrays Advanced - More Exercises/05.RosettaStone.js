function solve(params) {
    function fillTemplateMatrix(templateMatrix, messageMatrix, templateSize) {
        let originalCols = templateMatrix[0].length;
        for (let row = 0; row < templateSize; row++) {
            for (let tCol = 0, mCol = 0; mCol < messageMatrix[0].length - originalCols; mCol++ , tCol++) {
                if (tCol === templateMatrix[0].length) {
                    tCol = 0;
                }
                templateMatrix[row].push(templateMatrix[row][tCol]);
            }
        }
        for (let tRow = 0, mRow = 0; mRow < messageMatrix.length - templateSize; mRow++ , tRow++) {
            if (tRow === templateSize) {
                tRow = 0;
            }
            templateMatrix.push(templateMatrix[tRow]);
        }
        return templateMatrix;
    }

    function fillMessage(templateMatrix, messageMatrix) {
        let message = [];
        for (let row = 0; row < messageMatrix.length; row++) {
            for (let col = 0; col < messageMatrix[0].length; col++) {
                let currentCode = (templateMatrix[row][col] + messageMatrix[row][col]) % 27;
                if (currentCode === 0) {
                    message.push(' ');
                } else {
                    currentCode += 64;
                    message.push(String.fromCharCode(currentCode));
                }
            }
        }
        return message;
    }

    let templateSize = Number(params[0]);
    let templateMatrix = [];
    let messageMatrix = [];
    for (let i = 1; i < params.length; i++) {
        if (i <= templateSize) {
            templateMatrix.push(params[i].split(' ').filter(x => x !== '').map(Number));
        } else {
            messageMatrix.push(params[i].split(' ').filter(x => x !== '').map(Number));
        }
    }
    templateMatrix = fillTemplateMatrix(templateMatrix, messageMatrix, templateSize);
    let message = fillMessage(templateMatrix, messageMatrix);

    return message.join('');
}
console.log(solve(['1',
    '1 3 13', 
    '12 22 14 13 25 0 4 24 23',
    '18 24 2 25 22 0 0 11 18',
    '8 25 6 26 8 23 13 4 14',
    '14 3 14 10 6 1 6 16 14',
    '11 12 2 10 24 2 13 24 0',
    '24 24 10 14 15 25 18 24 12',
    '4 24 0 8 4 22 19 22 14',
    '0 11 18 26 1 19 18 13 15',
    '8 15 14 26 24 14 26 24 14']
));