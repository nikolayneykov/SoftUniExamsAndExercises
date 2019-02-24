function printPalindromes(numbers) {
    let isPalindrome = (a, b) => a === b;

    for (let i = 0; i < numbers.length; i++) {
        let currentNum = numbers[i];
        let reversedNum = Number(currentNum.toString().split('').reverse().join(''));

        console.log(isPalindrome(currentNum, reversedNum));
    }
}
printPalindromes([123, 323, 421, 121]);