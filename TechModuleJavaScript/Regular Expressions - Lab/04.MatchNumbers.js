function matchNumbers(numbers) {
    let regex = new RegExp(/(^|(?<=\s))(?<num>\-?\d+(\.\d+)*)($|(?=\s))/g)
    let result = [];
    let number = '';
    while ((number = regex.exec(numbers)) !== null) {
        result.push(number.groups['num']);
    }
    console.log(result.join(' '));
}
matchNumbers("1 -1 1s 123 s-s -123 _55_ _f 123.456 -123.456 s-1.1 s2 -1- zs-2 s-3.5");