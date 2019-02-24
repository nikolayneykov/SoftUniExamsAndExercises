function calculate(num1, num2, num3) {
    let result = '';
    if ((num1 < 0 && num2 < 0 && num3 < 0) ||
        (num1 < 0 && num2 > 0 && num3 > 0) ||
        (num1 > 0 && num2 < 0 && num3 > 0) ||
        (num1 > 0 && num2 > 0 && num3 < 0)) {
        result = 'Negative';
    } else {
        result = 'Positive';
    }

    console.log(result);
}
calculate(-5, -12, -15)

