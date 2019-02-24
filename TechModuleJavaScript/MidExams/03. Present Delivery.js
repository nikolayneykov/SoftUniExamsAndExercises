function printDeliveries(params) {
    params.pop();
    let houses = params.shift().split('@').map(Number);
    let santaIndex = 0;

    for (let param of params) {
        let jumpLength = Number(param.split(' ')[1]);
        santaIndex = (santaIndex + jumpLength) % houses.length;

        if (houses[santaIndex] <= 0) {
            console.log(`House ${santaIndex} will have a Merry Christmas.`);
        }
        houses[santaIndex] -= 2;
    }
    console.log(`Santa's last position was ${santaIndex}.`);
    let failedHouses = 0;
    for (let house of houses) {
        if (house > 0) {
            failedHouses++;
        }
    }

    if (failedHouses > 0) {
        console.log(`Santa has failed ${failedHouses} houses.`);
    } else {
        console.log('Mission was successful.');
    }
}
// printDeliveries([
//     '10@10@10@2',
//     'Jump 1',
//     'Jump 2',
//     'Merry Xmas!',
// ]);

printDeliveries([
    '2@4@2',
    'Jump 2',
    'Jump 2',
    'Jump 8',
    'Jump 3',
    'Jump 1',
    'Merry Xmas!',

])