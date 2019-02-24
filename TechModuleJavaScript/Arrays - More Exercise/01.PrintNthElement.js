function printElements(params) {
    let step = Number(params[params.length - 1]);
    let arr = params.slice(0, params.length - 1);
    let result = [];
    for (let i = 0; i < arr.length; i += step) {
        result.push(arr[i]);
    }
    return result.join(' ');
}
console.log(printElements(['5', '20', '31', '4', '20', '2']));