function manipulateArray(params) {
    function exchange(arr, index) {
        if (index < 0 || index >= arr.length) {
            console.log('Invalid index');
        } else {
            arr = arr.concat(arr.splice(0, index + 1));
        }
        return arr;
    }

    function printMax(arr, numType) {
        let maxNum = null;
        if (numType === 'odd') {
            maxNum = arr.filter(x => x % 2 === 1).sort((a, b) => b - a)[0];
        } else if (numType === 'even') {
            maxNum = arr.filter(x => x % 2 === 0).sort((a, b) => b - a)[0];
        }

        if (isNaN(maxNum)) {
            console.log('No matches');
        } else {
            let rightmostIndex = arr.lastIndexOf(maxNum);
            console.log(rightmostIndex);
        }
    }

    function printMin(arr, numType) {
        let minNum = null;
        if (numType === 'odd') {
            minNum = arr.filter(x => x % 2 === 1).sort((a, b) => a - b)[0];
        } else if (numType === 'even') {
            minNum = arr.filter(x => x % 2 === 0).sort((a, b) => a - b)[0];
        }

        if (isNaN(minNum)) {
            console.log('No matches');
        } else {
            let rightmostIndex = arr.lastIndexOf(minNum);
            console.log(rightmostIndex);
        }
    }

    function printFirst(arr, count, numType) {
        if (count > arr.length) {
            console.log('Invalid count');
        } else {
            if (numType === 'odd') {
                let firstOddNumbers = arr.filter(x => x % 2 === 1).slice(0, count);
                console.log(`[${firstOddNumbers.join(', ')}]`);
            } else if (numType === 'even') {
                let firstEvenNumbers = arr.filter(x => x % 2 === 0).slice(0, count);
                console.log(`[${firstEvenNumbers.join(', ')}]`);
            }
        }
    }

    function printLast(arr, count, numType) {
        if (count > arr.length) {
            console.log('Invalid count');
        } else {
            if (numType === 'odd') {
                let lastOddNumbers = arr.filter(x => x % 2 === 1).reverse().slice(0, count).reverse();
                console.log(`[${lastOddNumbers.join(', ')}]`);
            } else if (numType === 'even') {
                let lastEvenNumbers = arr.filter(x => x % 2 === 0).reverse().slice(0, count).reverse();
                console.log(`[${lastEvenNumbers.join(', ')}]`);
            }
        }
    }

    let arr = params[0].split(' ').filter(x => x !== '').map(Number);

    for (let i = 1; i < params.length; i++) {
        let tokens = params[i].split(' ').filter(x => x !== '');
        let command = tokens[0];

        if (command === 'exchange') {
            let index = Number(tokens[1]);
            arr = exchange(arr, index);
        } else if (command === 'max') {
            let numType = tokens[1];
            printMax(arr, numType);
        } else if (command === 'min') {
            let numType = tokens[1];
            printMin(arr, numType);
        } else if (command === 'first') {
            let count = Number(tokens[1]);
            let numType = tokens[2];
            printFirst(arr, count, numType);
        } else if (command === 'last') {
            let count = Number(tokens[1]);
            let numType = tokens[2];
            printLast(arr, count, numType);
        }
    }
    console.log(`[${arr.join(', ')}]`);
}

manipulateArray(['1 3 5 7 9',
    'exchange 1',
    'max odd',
    'min even',
    'first 2 odd',
    'last 2 even',
    'exchange 3']
);