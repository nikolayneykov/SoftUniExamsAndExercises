function solve(params) {
    let garages = {};
    for (let p of params) {
        let tokens = p.split(' - ');
        let garageNumber = Number(tokens[0]);
        if (garages[garageNumber] === undefined) {
            garages[garageNumber] = [];
        }
        let car = tokens[1].replace(new RegExp(': ', 'g'), ' - ');
        garages[garageNumber].push(car);
    }
    let sortedGarages = Object.keys(garages).sort((a, b) => a - b);
    for (let garage of sortedGarages) {
        console.log(`Garage № ${garage}`);
        for (let car of garages[garage]) {
            console.log(`--- ${car}`);
        }
    }
}
solve(['1 - color: blue, fuel type: diesel', '1 - color: red, manufacture: Audi', '2 - fuel type: petrol', '4 - color: dark blue, fuel type: diesel, manufacture: Fiat']);