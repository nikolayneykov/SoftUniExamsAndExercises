function printPalindromes(words) {
    let palindromes = [];

    for (let w of words) {
        let word = w.split(' ').join('');
        let reversedWord = word.split('').reverse().join('');

        if (word === reversedWord) {
            palindromes.push(word);
        }
    }

    if (palindromes.length > 0) {
        console.log(palindromes.join(', '));
    } else {
        console.log('No palindromes found');
    }
}
printPalindromes([
    ' stella won no wallets',
    'not a palindrome'
]);