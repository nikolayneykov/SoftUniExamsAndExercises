function addAndSubtract(num1, num2, num3) {
    let add = (a, b) => a + b;
    let subtract = (a, b) => a - b;

    let result = add(num1,num2);
    result = subtract(result,num3);
    console.log(result)
}
addAndSubtract(23, 6, 10);