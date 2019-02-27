function calculateResult(leftOperand, rightOperand, operator) {
    let calculate = {
        '+': (a, b) => a + b,
        '-': (a, b) => a - b,
        '*': (a, b) => a * b,
        '/': (a, b) => a / b,
        '%': (a, b) => a % b,
    };

    console.log(calculate[operator](leftOperand, rightOperand));
}

calculateResult(3, 5.5, '*');