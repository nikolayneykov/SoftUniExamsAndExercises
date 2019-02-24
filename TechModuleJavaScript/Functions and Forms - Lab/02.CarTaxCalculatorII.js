function printTax(kW, age) {
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

    let power = Number(kW);
    age = Number(age);
    let tax = calculateCarTax(power);
    let coefficient = calculateCoefficient(age);
    tax *= coefficient;
    console.log(tax.toFixed(2), 'lv.');
}
printTax(45, 10);

// ·	under 5 year - 2.80
// ·	5 – 14 year - 1.50
// ·	up to– 14 - 1.00
