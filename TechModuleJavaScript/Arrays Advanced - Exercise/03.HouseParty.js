function printGuests(guests) {
    let guestList = [];

    for (let guest of guests) {
        let tokens = guest.split(' is ').filter(x => x !== '');
        let name = tokens[0];
        let index = guestList.indexOf(name);

        if (tokens[1] === 'going!') {
            if (index === -1) {
                guestList.push(name);
            } else {
                console.log(`${name} is already in the list!`);
            }
        } else if (tokens[1] === 'not going!') {
            if (index !== -1) {
                guestList.splice(index, 1);
            }else{
                console.log(`${name} is not in the list!`);
            }
        }
    }
    
    console.log(guestList.join('\n'));
}
printGuests(['Allie is going!',
    'George is going!',
    'John is not going!',
    'George is not going!']
);