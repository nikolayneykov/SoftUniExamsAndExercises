function rotateArray(arr, count) {
    while (count > 0) {
        arr.push(arr.shift());
        count--;
    }
    
    console.log(arr.join(' '));
}
rotateArray([51, 47, 32, 61, 21], 2);


