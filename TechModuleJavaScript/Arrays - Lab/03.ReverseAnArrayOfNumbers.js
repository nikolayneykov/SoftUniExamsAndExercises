function reverseNumbers(n, arr) {
    let reversedArr = [];
    for (let i = n - 1; i >= 0; i--) {
        reversedArr.push(arr[i]);
    }
    console.log(reversedArr.join(' '));
}
reverseNumbers(3, [10, 20, 30, 40, 50]);