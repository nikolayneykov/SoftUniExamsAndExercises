function printTax(type, kW, age) {
    function calculateCarTax(power) {
        let taxPrice = 0;
        if (power <= 37) {
            taxPrice = power * 0.43
        } else if (power > 37 && power <= 55) {
            taxPrice = power * 0.50;
        } else if (power > 55 && power <= 74) {
            taxPrice = power * 0.68;
        } else if (power > 74 && power <= 110) {
            taxPrice = power * 1.38;
        } else if (power > 110) {
            taxPrice = power * 1.54;
        }
        return taxPrice;
    }
    function calculateCoefficient(age) {
        let coefficient = 0;
        if (age < 5) {
            coefficient = 2.80;
        } else if (age >= 5 && age <= 14) {
            coefficient = 1.50;
        } else if (age > 14) {
            coefficient = 1.00;
        }
        return coefficient;
    }
    function calculateMotorcycleTax(volume) {
        let taxPrice = 0;
        if (volume > 750) {
            taxPrice = 125;
        } else if (volume > 490) {
            taxPrice = 94;
        } else if (volume > 350) {
            taxPrice = 63;
        } else if (volume > 250) {
            taxPrice = 44;
        } else if (volume > 125) {
            taxPrice = 31;
        } else {
            taxPrice = 15;
        }
        return taxPrice;
    }

    let power = Number(kW);
    let tax = 0;
    if (type === 'car') {
        age = Number(age);
        tax = calculateCarTax(power);
        let coefficient = calculateCoefficient(age);
        tax *= coefficient;
    } else if (type === 'motorcycle') {
        tax = calculateMotorcycleTax(power);
    }
    console.log(tax.toFixed(2), 'lv.');
}

printTax('motorcycle',
450,
10,
);