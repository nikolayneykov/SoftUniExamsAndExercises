function greatestCD() {
    let a = +document.querySelector('#num1').value;
    let b = +document.querySelector('#num2').value;

    while (b !== 0) {
        let tmp = a;
        a = b;
        b = tmp % b;
    }

    document.querySelector('#result').textContent = a;
}