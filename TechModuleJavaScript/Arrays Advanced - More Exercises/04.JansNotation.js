function solve(instructions) {
    let operands = [];

    for (let i of instructions) {
        let isOperator = i === '+' || i === '-' || i === '*' || i === '/';
        if (isOperator) {
            if (operands.length < 2) {
                console.log('Error: not enough operands!');
                return;
            } else {
                let operand1 = operands.pop();
                let operand2 = operands.pop();
                switch (i) {
                    case '+': operand2 += operand1; break;
                    case '-': operand2 -= operand1; break;
                    case '*': operand2 *= operand1; break;
                    case '/': operand2 /= operand1; break;
                }
                operands.push(operand2);
            }
        } else {
            operands.push(i);
        }
    }

    return operands.length > 1 ? "Error: too many operands!" : operands[0];
}
console.log(solve([5,
    3,
    4,
    '*',
    '-']
));