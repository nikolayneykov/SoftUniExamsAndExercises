function buyFruit(fruit, weight, pricePerKg) {
    weight /= 1000;
    let totalPrice = weight*pricePerKg;

    console.log(`I need ${totalPrice.toFixed(2)} leva to buy ${weight.toFixed(2)} kilograms ${fruit}.`);
}

buyFruit('orange', 2500, 1.80);