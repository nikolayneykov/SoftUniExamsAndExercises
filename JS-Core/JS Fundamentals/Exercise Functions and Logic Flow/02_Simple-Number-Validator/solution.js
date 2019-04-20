function validate() {
    const weights = [2, 4, 8, 5, 10, 9, 7, 3, 6];
    let input = document.querySelector('input');
    let response = document.querySelector('#response');
    document.querySelector('button').addEventListener('click', validateNumber);
    
    function validateNumber() {
        let digits = input.value.split('').map(Number);
        let lastDigit = digits.pop();
        let sum = digits.map((n, i) => n * weights[i]).reduce((a, b) => a + b, 0);
        let remainder = sum % 11;

        if (remainder === 10) {
            remainder = 0;
        }

        response.textContent = lastDigit === remainder
            ? 'This number is Valid!'
            : 'This number is NOT Valid!';
    }
}

