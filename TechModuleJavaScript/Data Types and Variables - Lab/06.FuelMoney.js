function calculateFuelMoney(distance, passangers, price) {
    let consumedFuel = (distance / 100) * 7;
    consumedFuel += passangers * 0.100;
    let totalPrice = consumedFuel*price;
    console.log(`Needed money for that trip is ${totalPrice}lv.`);
}

calculateFuelMoney(90, 14, 2.88);