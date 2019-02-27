function printGCD(a, b) {
    while (b !== 0) {
        let t = b;
        b = a % b;
        a = t;
    }

    console.log(a);
}

printGCD(5, 15);
