function rotateArray(params) {
    let result = 'Empty';
    let rotations = Number(params[params.length - 1]);
    if (rotations != NaN) {
        result = params.slice(0, params.length - 1);
        while (rotations > 0) {
            result.unshift(result.pop());
            rotations--;
        }
        result = result.join(' ');
    }
    return result;
}
console.log(rotateArray(['1', '2', '3', '4', '2']));