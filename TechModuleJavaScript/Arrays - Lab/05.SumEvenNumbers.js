function sumEvenNumbers(arr) {
    let sum = 0;
    for (let i = 0; i < arr.length; i++) {
        let currentNumber = Number(arr[i]);
        if (currentNumber % 2 === 0) {
            sum+=currentNumber;
        }
    }
    console.log(sum);
}
sumEvenNumbers(['1', '2', '3', '4', '5', '6']);