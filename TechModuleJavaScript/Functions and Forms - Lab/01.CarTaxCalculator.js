function printTax(kW) {
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
    let power = Number(kW);
    let tax = calculateCarTax(power);
    console.log(tax.toFixed(2),'lv.');
}
printTax(57.50);

// ·	under 37 kW - 0.43 lv./kW
// ·	37.01 – 55 kW - 0.50 lv./kW 
// ·	55.01 – 74.00 - 0.68 lv./kW
// ·	74.01 – 110.00 - 1.38 lv./kW 
// ·	up 110.00 - 1.54 lv./kW
