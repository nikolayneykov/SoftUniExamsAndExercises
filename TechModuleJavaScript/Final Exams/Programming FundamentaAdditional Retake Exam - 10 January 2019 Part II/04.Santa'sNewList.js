function solve(params) {
    params.pop();
    let children = {};
    let presents = {};

    for (let param of params) {
        if (param.startsWith('Remove')) {
            let child = param.split('->')[1];
            delete children[child];
        } else {
            let [child, present, count] = param.split('->');

            if (!children.hasOwnProperty(child)) {
                children[child] = 0;
            }

            if (!presents.hasOwnProperty(present)) {
                presents[present] = 0;
            }

            children[child] += Number(count);
            presents[present] += Number(count);
        }
    }

    console.log(`Children:`);
    Object.entries(children)
        .sort((a, b) => {
            let result = b[1] - a[1];

            if (result === 0) {
                result = a[0].localeCompare(b[0]);
            }

            return result;
        }).forEach(c=>console.log(`${c[0]} -> ${c[1]}`));

    console.log('Presents:');
    for(let present in presents){
        console.log(`${present} -> ${presents[present]}`);
    }
}

solve(
    [
        'Marty->Toys->5',
        'Sam->Candy->20',
        'Leo->Candy->10',
        'Leo->Toys->1',
        'Katy->Clothes->4',
        'Bobbie->Clothes->6',
        'Tanya->Phone->1',
        'Nasko->Tablet->3',
        'END'
    ]

)