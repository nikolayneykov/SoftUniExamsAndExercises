function extractSubsequence(arr) {
    let result = [];
    result.push(arr.shift());
    while (arr.length > 0) {
        if (result[result.length - 1] <= arr[0]) {
            result.push(arr.shift());
        } else {
            arr.shift();
        }
    }
    return result.join(' ');
}
console.log(extractSubsequence([1, 3, 8, 4, 10, 12, 3, 2, 24]));
