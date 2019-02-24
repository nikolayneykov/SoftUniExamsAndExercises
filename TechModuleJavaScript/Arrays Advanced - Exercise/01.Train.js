function printTrain(params) {
    let train = params[0].split(' ').filter(x => x !== '').map(Number);
    let wagonCapacity = Number(params[1]);

    for (let i = 2; i < params.length; i++) {
        let tokens = params[i].split(' ');

        if (tokens[0] === 'Add') {
            let wagon = Number(tokens[1]);
            train.push(wagon);
        } else {
            let passengers = Number(tokens[0]);

            for (let j = 0; j < train.length; j++) {
                if (train[j] + passengers <= wagonCapacity) {
                    train[j] += passengers;
                    break;
                }
            }
        }
    }

    console.log(train.join(' '));
}
printTrain(['32 54 21 12 4 0 23',
    '75',
    'Add 10',
    'Add 0',
    '30',
    '10',
    '75']
);