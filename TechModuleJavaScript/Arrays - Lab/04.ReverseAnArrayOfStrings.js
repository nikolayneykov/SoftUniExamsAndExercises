function reverseArray(arr) {
    let reversedArr = [];
    for (let i = arr.length - 1; i >= 0; i--) {
        reversedArr.push(arr[i]);
    }
    console.log(reversedArr.join(' '));
}
reverseArray(['a', 'b', 'c', 'd', 'e']);