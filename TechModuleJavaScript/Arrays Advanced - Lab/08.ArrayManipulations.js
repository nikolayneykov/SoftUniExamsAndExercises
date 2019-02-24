function maninpulateArray(params) {
    let arr = params[0].split(' ').filter(x => x !== '').map(Number);

    for (let i = 1; i < params.length; i++) {
        let tokens = params[i].split(' ').filter(x => x !== '');
        let command = tokens[0];

        if (command === 'Add') {
            let numberToAdd = Number(tokens[1]);
            arr.push(numberToAdd);
        } else if (command === 'Remove') { 
            let numberToRemove = Number(tokens[1]);
            arr = arr.filter(num => num !== numberToRemove);
        } else if (command === 'RemoveAt') {
            let index = Number(tokens[1]);
            arr.splice(index, 1);
        } else if (command === 'Insert') {
            let numberToInsert = Number(tokens[1]);
            let index = Number(tokens[2]);
            arr.splice(index, 0, numberToInsert);
        }
    }
    console.log(arr.join(' '));
}
maninpulateArray(["4 19 2 53 6 43",
    "Add 3",
    "Remove 2",
    "RemoveAt 1",
    "Insert 8 3"]
);