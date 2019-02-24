function compareArrays(arr1, arr2) {
    let index = 0;
    let areEqual = true;
    let sum = 0;
    while (index < arr1.length && index < arr2.length) {
        if (arr1[index] !== arr2[index]) {
            areEqual = false;
            break;
        }
        sum += Number(arr1[index]);
        index++;
    }

    if (areEqual) {
        console.log(`Arrays are identical. Sum: ${sum}`);
    }else{
        console.log(`Arrays are not identical. Found difference at ${index} index`);
    }
}
compareArrays(['10', '20', '30'], ['10', '20', '30']);