function roundNumbers(number, precision) {
    console.log(parseFloat(number.toFixed(Math.min(precision,15))));
}
roundNumbers(10.5, 3);