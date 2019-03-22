function solve(params) {
    params.shift();
    let attacked = [];
    let destroyed = [];
    let regex = /@([A-Za-z]+)[^@\-!:>]*:\d+[^@\-!:>]*!(A|D)![^@\-!:>]*->\d+/;

    for (let encryptedMessage of params) {
        let count = encryptedMessage
            .toLowerCase()
            .split('')
            .filter(c => c === 's' || c === 't' || c === 'a' || c === 'r')
            .length;

        let decryptedMessage = encryptedMessage
            .split('')
            .map(c => String.fromCharCode(c.charCodeAt(0) - count))
            .join('');

        let match = decryptedMessage.match(regex);

        if (match) {
            if (match[2] === 'A') {
                attacked.push(match[1]);
            } else if (match[2] === 'D') {
                destroyed.push(match[1]);
            }
        }
    }

    console.log(`Attacked planets: ${attacked.length}`);
    attacked.sort((a, b) => a.localeCompare(b)).forEach(p => console.log(`-> ${p}`));
    console.log(`Destroyed planets: ${destroyed.length}`);
    destroyed.sort((a, b) => a.localeCompare(b)).forEach(p => console.log(`-> ${p}`));
}

solve(
    [
        '2',
        'STCDoghudd4=63333$D$0A53333',
        'EHfsytsnhf?8555&I&2C9555SR'
    ]
);