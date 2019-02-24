function findEqualSums(arr) {
    let result = 'no';

    for (let i = 0; i < arr.length; i++) {
        let leftSum = 0;
        let rightSum = 0;

        for (let j = i - 1; j >= 0; j--) {
            leftSum += arr[j];
        }

        for (let k = i + 1; k < arr.length; k++) {
            rightSum += arr[k];
        }

        if (leftSum === rightSum) {
            result = i;
            break;
        }
    }
    
    console.log(result);
}
findEqualSums([1, 2, 3, 3]);