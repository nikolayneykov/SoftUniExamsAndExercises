function condenseArray(arr) {

    while (arr.length > 1) {
        let condensedArr = [];
        for (let i = 0; i < arr.length - 1; i++) {
            condensedArr.push(arr[i] + arr[i + 1]);
        }
        arr = condensedArr;
    }
    console.log(arr[0]);
}
condenseArray([2, 10, 3]);