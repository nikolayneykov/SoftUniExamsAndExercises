function printParkingLot(params) {
    let parkingData = {};

    for (let param of params) {
        let tokens = param.split(', ');
        let position = tokens[0];
        let carNumber = tokens[1];
        parkingData[carNumber] = position;
    }

    let sortedCarNumbers = Object.entries(parkingData)
        .filter(n => n[1] === 'IN')
        .map(n => n[0])
        .sort((a, b) => a.localeCompare(b));

    console.log(sortedCarNumbers.length > 0 ?
                sortedCarNumbers.join('\n') :
               'Parking Lot is Empty');
}
printParkingLot(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'IN, CA9999TT',
    'IN, CA2866HI',
    'OUT, CA1234TA',
    'IN, CA2844AA',
    'OUT, CA2866HI',
    'IN, CA9876HH',
    'IN, CA2822UU']
);
