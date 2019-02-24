function printBiggestNumber(num1, num2, num3) {
    return (num1 >= num2 && num1 >= num3) ? num1 : (num2 >= num1 && num2 >= num3) ? num2 : num3;
}
console.log(printBiggestNumber(43, 43.2, 43.1))