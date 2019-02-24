function printTopIntegers(arr) {
    let topIntegers = [];
    for (let i = 0; i < arr.length; i++) {
        let currentNum = arr[i];
        let isTopInteger = true;
        
        for (let j = i + 1; j < arr.length; j++) {
            if (currentNum <= arr[j]) {
                isTopInteger = false;
                break;
            } 
        }

        if (isTopInteger) {
            topIntegers.push(currentNum);
        }
    }

    console.log(topIntegers.join(' '));
}
printTopIntegers([14, 24, 3, 19, 15, 17]);