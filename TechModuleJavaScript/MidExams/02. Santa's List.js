function printList(params) {
    params.pop();
    let kidList = params.shift().split('&');

    for (let param of params) {
        let tokens = param.split(' ');
        let command = tokens[0];
        let kidName = tokens[1];
        let index = kidList.indexOf(kidName);

        if (command === 'Bad' && index === -1) {
            kidList.unshift(kidName);
        } else if (command === 'Good' && index !== -1) {
            kidList.splice(index, 1);
        } else if (command === 'Rename' && index !== -1) {
            let newName = tokens[2];
            kidList[index] = newName;
        } else if (command === 'Rearrange' && index !== -1) {
            let kid = kidList.splice(index, 1);
            kidList.push(kid);
        }
    }
    console.log(kidList.join(', '));
}

printList([
    'Joshua&Aaron&Walt&Dustin&William',
    'Good Walt',
    'Bad Jon',
    'Rename Aaron Paul',
    'Rearrange Jon',
    'Rename Peter George',
    'Finished!'
]);
// printList(['Peter&George&Mike',
//     'Bad Joshua',
//     'Good Peter',
//     'Finished!',
// ]);