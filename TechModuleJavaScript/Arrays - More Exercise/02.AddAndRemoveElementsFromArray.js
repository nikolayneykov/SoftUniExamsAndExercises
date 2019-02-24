function modifyArray(params) {
    let arr = [];
    for (let i = 0; i < params.length; i++) {
        switch (params[i]) {
            case 'add': arr.push(i + 1); break;
            case 'remove': arr.pop(); break;
        }
    }
    return arr.length > 0 ? arr.join(' ') : 'Empty';
}
console.log(modifyArray(['add', 'add', 'add', 'add']));