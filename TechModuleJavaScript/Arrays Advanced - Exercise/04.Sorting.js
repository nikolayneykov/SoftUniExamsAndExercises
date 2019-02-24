function sort(arr) {
    arr = arr.sort((a, b) => b - a);
    let sortedArr = [];

    while (arr.length > 0) {
        sortedArr.push(arr.shift());
        sortedArr.push(arr.pop());
    }

    console.log(sortedArr.join(' '));
}
sort([1, 21, 3, 52, 69, 63, 31, 2, 18, 94, 22]);