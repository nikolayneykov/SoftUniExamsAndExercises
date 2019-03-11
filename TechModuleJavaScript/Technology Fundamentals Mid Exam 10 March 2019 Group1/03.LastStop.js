function solve(params) {
    params.pop();
    let paintings = params.shift().split(' ').map(Number);

    for (let param of params) {
        let tokens = param.split(' ');
        let command = tokens[0];
        let paintingNumber = command !== 'Insert' ? +tokens[1] : +tokens[2];
        let paintingNumber2 = +tokens[2];
        let changedNumber = +tokens[2];
        let place = +tokens[1];
        let index = paintings.indexOf(paintingNumber);

        if (command === 'Change' && index !== -1) {

            paintings[index] = changedNumber;
        } else if (command === 'Hide' && index !== -1) {
            paintings = paintings.filter(x => x !== paintingNumber);
        } else if (command === 'Switch' && index !== -1 && paintings.indexOf(paintingNumber2) !== -1) {
            paintings[paintings.indexOf(paintingNumber2)] = paintingNumber;
            paintings[index] = paintingNumber2;
        } else if (command === 'Insert' && place >= 0 && place < paintings.length) {
            paintings.splice(place + 1, 0, paintingNumber);
        } else if (command === 'Reverse') {
            paintings.reverse();
        }
    }

    console.log(paintings.join(' '));
}

solve([
    '115 115 101 114 73 111 116 75',
    'Insert 5 114',
    'Switch 116 73',
    'Hide 75',
    'Reverse',
    'Change 73 70',
    'Insert 10 85',
    'END'
])