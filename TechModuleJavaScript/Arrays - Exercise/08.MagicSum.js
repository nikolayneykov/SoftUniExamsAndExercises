function printUniquePairs(params) {
    let arr = params[0].split(' ').map(Number);
    let num = Number(params[1]);

    for (let i = 0; i < arr.length; i++) {
        for (let j = i + 1; j < arr.length; j++) {
            if ((arr[i] + arr[j]) === num) {
                console.log(arr[i] + ' ' + arr[j]);
            }
        }
    }
}
printUniquePairs(['14 20 60 13 7 19 8', '27']);