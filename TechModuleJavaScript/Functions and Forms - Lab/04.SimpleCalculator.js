function calculate(leftOperand, rightOperand, operator) {
    let result = 0;
    let add = (a, b) => a + b;
    let subtract = (a, b) => a - b;
    let multiply = (a, b) => a * b;
    let divide = (a, b) => a / b;

    switch (operator) {
        case 'add': result = add(leftOperand, rightOperand); break;
        case 'subtract': result = subtract(leftOperand, rightOperand); break;
        case 'multiply': result = multiply(leftOperand, rightOperand); break;
        case 'divide': result = divide(leftOperand, rightOperand); break;
    }

    console.log(result);
}
calculate(9,
    5,
    'multiply'
);
