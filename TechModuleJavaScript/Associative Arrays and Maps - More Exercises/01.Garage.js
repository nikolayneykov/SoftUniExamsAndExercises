function solveGarage(params) {
    let garages = new Map();
    for (let param of params) {
        let tokens = param.split(' - ');
        let garageNumber = Number(tokens[0]);
        let carInfo = tokens[1].split(': ').join(' - ');
 
        if (!garages.has(garageNumber)) {
            garages.set(garageNumber, []);
        }
 
        garages.get(garageNumber).push(carInfo);
    }
    let sortedGarages = [...garages];
    for (let [garage, cars] of sortedGarages) {
        console.log(`Garage № ${garage}`);
        for (let car of cars) {
            console.log(`--- ${car}`);
        }
    }
}
solve(['1 - color: blue, fuel type: diesel', '1 - color: red, manufacture: Audi', '2 - fuel type: petrol', '4 - color: dark blue, fuel type: diesel, manufacture: Fiat']);