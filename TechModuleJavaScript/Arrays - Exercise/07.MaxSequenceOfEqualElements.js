function printLongestSequence(params) {
    let arr = params[0].split(' ');
    let longestSequence = [];
    
    for (let i = 0; i < arr.length; i++) {
        let tempSequence = [];
        for (let j = i; j < arr.length; j++) {
            if (arr[i] === arr[j]) {
                tempSequence.push(arr[i]);
            } else {
                break;
            }
        }

        if (longestSequence.length < tempSequence.length) {
            longestSequence = tempSequence;
        }
    }
    
    console.log(longestSequence.join(' '));
}
printLongestSequence(['2 1 1 2 3 3 2 2 2 1']);