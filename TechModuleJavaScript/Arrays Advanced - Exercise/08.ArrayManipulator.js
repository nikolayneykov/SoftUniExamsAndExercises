function manipulateArray(arr, commands) {

    for (let c of commands) {
        let tokens = c.split(' ');
        let command = tokens[0];

        if (command === 'add') {
            let index = Number(tokens[1]);
            let element = Number(tokens[2]);
            arr.splice(index, 0, element);
        } else if (command === 'addMany') {
            let index = Number(tokens[1]);
            let elements = tokens.slice(2).map(Number);
            arr.splice(index, 0, ...elements);
        } else if (command === 'contains') {
            let element = Number(tokens[1]);
            console.log(arr.indexOf(element));
        } else if (command === 'remove') {
            let index = Number(tokens[1]);
            arr.splice(index, 1);
        } else if (command === 'shift') {
            let positions = Number(tokens[1]);
            while (positions > 0) {
                arr.push(arr.shift());
                positions--;
            }
        } else if (command === 'sumPairs') {
            arr = arr
                .map((e, i, arr) => (i < arr.length - 1) ? (arr[i] += arr[i + 1]) : (arr[i] = arr[i]))
                .filter((e, i) => i % 2 === 0);

        } else if (command === 'print') {
            break;
        }
    }

    console.log(arr);
}
manipulateArray(
    [1, 2, 4, 5, 6, 7],
    ['add 1 8', 'contains 1', 'contains 3', 'print']
);
