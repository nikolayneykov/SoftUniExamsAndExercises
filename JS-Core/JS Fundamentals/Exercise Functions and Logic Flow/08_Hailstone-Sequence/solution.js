function getNext() {
    let num = +document.querySelector('#num').value;
    let result = document.querySelector('#result');

    while (true) {
        result.textContent += num + ' ';

        if (num === 1) {
            break;
        } else if (num % 2 === 0) {
            num /= 2;
        } else {
            num *= 3;
            num++;
        }
    }
}