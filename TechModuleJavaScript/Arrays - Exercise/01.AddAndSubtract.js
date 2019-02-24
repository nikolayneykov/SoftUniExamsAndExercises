function modifyArray(arr) {
    let originalSum = 0;
    let modifiedSum = 0;

    for (let i = 0; i < arr.length; i++) {
        originalSum += arr[i];
        if (arr[i] % 2 === 0) {
            arr[i] += i;
        } else {
            arr[i] -= i;
        }
        modifiedSum += arr[i];
    }
    
    console.log(`[ ${arr.join(', ')} ]\n${originalSum}\n${modifiedSum}`);
}
modifyArray([5, 15, 23, 56, 35]);

