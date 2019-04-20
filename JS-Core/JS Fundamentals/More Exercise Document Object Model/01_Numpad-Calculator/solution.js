function solve() {
    let validExpressionPattern = /(\d+(\.\d+)?)\s([+\-*/])\s(\d+(\.\d+)?)/;
    let expression = document.querySelector('p#expressionOutput');
    let resultOutput = document.querySelector('p#resultOutput');
    [...document.querySelectorAll('button')]
        .filter(x => x.value !== '=' && x.value !== 'Clear')
        .forEach(x => x.addEventListener('click', displayExpression));

    document.querySelector('button[value="="]').addEventListener('click', displayResult);
    document.querySelector('button[value="Clear"]').addEventListener('click', clear);

    function displayExpression() {
        if (this.value === '+' || this.value === '-' || this.value === '*'|| this.value ==='/') {
            expression.textContent += ` ${this.value} `;
        }else{
            expression.textContent += this.value;
        }
    }

    function displayResult() {
        let match = expression.textContent.match(validExpressionPattern);
        if (match) {
            let leftOperand = +match[1];
            let operator = match[3];
            let rightOperand = +match[4];
            let result = 0;
            switch (operator) {
                case '+': result = leftOperand + rightOperand; break;
                case '-': result = leftOperand - rightOperand; break;
                case '*': result = leftOperand * rightOperand; break;
                case '/': result = leftOperand / rightOperand; break;
            }

            resultOutput.textContent = result;
        } else {
            resultOutput.textContent = 'NaN';
        }
    }

    function clear() {
        expression.textContent = '';
        resultOutput.textContent = '';
    }
}