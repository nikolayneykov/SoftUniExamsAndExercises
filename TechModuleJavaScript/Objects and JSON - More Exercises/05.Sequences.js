function solve(params) {
    let result = [];
    for (let p of params) {
        let arr = p.split(/[\[\],\s]+/).filter(x => x !== '').map(Number).sort((a, b) => b - a);
        if (!result.includes(arr.toString())) {
            result.push(arr.toString());
        }
    }

    result.forEach((element, index, array) => array[index] = element.split(','));
    result.sort((a, b) => a.length - b.length);
    result.forEach(x => console.log(`[${x.join(', ')}]`));
}
solve(["[-3, -2, -1, 0, 1, 2, 3, 4]",
    "[10, 1, -17, 0, 2, 13]",
    "[4, -3, 3, -2, 2, -1, 1, 0]"]
);