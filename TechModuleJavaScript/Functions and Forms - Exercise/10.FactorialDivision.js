function calcFactoriel(num1, num2) {
    function calculate(num) {
        if (num === 1) {
            return 1;
        }
        return num * calculate(num - 1);
    }
    let factoriel1 = calculate(num1);
    let factoriel2 = calculate(num2);
    
    console.log((factoriel1/factoriel2).toFixed(2));  
}
calcFactoriel(5, 2);


