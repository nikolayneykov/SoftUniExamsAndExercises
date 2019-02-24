function printPalindromes(params) {
    function isPallindrome(text) {
        let startIndex = 0;
        let endIndex = text.length - 1;
        let result = true;
        while (startIndex < endIndex) {
            if (text[startIndex] !== text[endIndex]) {
                result = false;
                break;
            }
            startIndex++;
            endIndex--;
        }
        return result;
    }
    let result = [];
    for (let p of params) {
        let text = p.split(' ').join('');
        if (isPallindrome(text)) {
            result.push(text);
        }
    }
    if (result.length === 0) {
        console.log('No palindromes found');
    } else {
        console.log(result.join(', '));
    }
}
printPalindromes([' stella won no wallets',
    'not a palindrome']
);