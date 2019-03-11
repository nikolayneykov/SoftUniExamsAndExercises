function solve(params) {
    let days = Number(params.shift());
    let budget = Number(params.shift());
    let peopleCount = Number(params.shift());
    let fuelPrice = Number(params.shift());
    let foodPrice = Number(params.shift());
    let hotelPrice = Number(params.shift());

    foodPrice *= days * peopleCount;
    hotelPrice *= days * peopleCount;

    if (peopleCount > 10) {
        hotelPrice *= 0.75;
    }

    let totalExpenses = foodPrice + hotelPrice;
    let currentDay = 1;
    
    for (let distance of params) {
        if (totalExpenses > budget) {
            break;
        }

        totalExpenses += fuelPrice * Number(distance);

        if (currentDay % 3 === 0 || currentDay % 5 === 0) {
            totalExpenses *= 1.4;
        }

        if (currentDay % 7 === 0) {
            totalExpenses -= totalExpenses / peopleCount;
        }

        currentDay++;
    }

    console.log(budget >= totalExpenses ?
        `You have reached the destination. You have ${(budget - totalExpenses).toFixed(2)}$ budget left.` :
        `Not enough money to continue the trip. You need ${(totalExpenses - budget).toFixed(2)}$ more.`)
}

solve([
    '7',
    '12000',
    '5',
    '1.5',
    '10',
    '20',
    '512',
    '318',
    '202',
    '154',
    '222',
    '108',
    '123',
]);
