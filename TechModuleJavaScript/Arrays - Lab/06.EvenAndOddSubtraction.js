function evenAndOddSumSubtraction(arr) {
    let evenSum = 0;
    let oddSum = 0;
    for (let i = 0; i < arr.length; i++) {
        let currentNum = arr[i];
        if (currentNum % 2 === 0) {
            evenSum += currentNum;
        } else {
            oddSum += currentNum;
        }
    }
    console.log(evenSum - oddSum);
}
evenAndOddSumSubtraction([1, 2, 3, 4, 5, 6]);