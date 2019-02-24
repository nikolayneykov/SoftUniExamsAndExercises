function isLowerOrUpper(char) {
    let result = '';
    let charToLower = char.toLowerCase();
    if (charToLower === char) {
        result = 'lower-case';
    } else {
        result = 'upper-case';
    }
    console.log(result);
}
isLowerOrUpper('a');