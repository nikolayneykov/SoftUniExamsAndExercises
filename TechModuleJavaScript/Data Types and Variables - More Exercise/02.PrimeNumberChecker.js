function checkPrime(num) {
    function solve(num, divisor) {
        if (divisor > Math.sqrt(num)) {
            return true;
        }
        if (num % divisor == 0) {
            return false;
        }
        return solve(num, divisor + 1);
    }
    let isPrime = solve(num, 2)
    return isPrime;
}
console.log(checkPrime(7));
