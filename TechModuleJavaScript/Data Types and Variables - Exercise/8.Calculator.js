function calculator(leftOperand, operator, rightOperand) {
    let result = 0;
    switch (operator) {
        case '+': result = leftOperand + rightOperand; break;
        case '-': result = leftOperand - rightOperand; break;
        case '*': result = leftOperand * rightOperand; break;
        case '/': result = leftOperand / rightOperand; break;
    }
    console.log(result.toFixed(2));
}

calculator(5, '*', 2);