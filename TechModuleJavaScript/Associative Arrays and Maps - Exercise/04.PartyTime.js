function printGuests(params) {
    let partyIndex = params.indexOf('PARTY');
    let guestList = params.slice(0, partyIndex);

    for (let i = partyIndex + 1; i < params.length; i++) {
        let guest = params[i];
        let guestIndex = guestList.indexOf(guest);
        guestList.splice(guestIndex, 1);
    }

    let result = guestList.filter(g => Number.isInteger(+g[0]))
        .concat(guestList.filter(g => !Number.isInteger(+g[0])));
    console.log(`${result.length}\n${result.join('\n')}`);
}
printGuests([
    '7IK9Yo0h',
    '9NoBUajQ',
    'Ce8vwPmE',
    'SVQXQCbc',
    'tSzE5t0p',
    'PARTY',
    '9NoBUajQ',
    'Ce8vwPmE',
    'SVQXQCbc'
]
);